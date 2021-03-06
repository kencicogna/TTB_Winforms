﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManager.Events;
using ProductManager.Models;
using ProductManager.Views.Inventory;
using System.Data.SqlClient;
using System.Net;
using System.IO;
using System.Drawing;
using System.Configuration;
using System.Text.RegularExpressions;

namespace ProductManager.Presenters.Inventory
{
    public class InventorySearchResultsPresenter
    {
        private UCInventorySearchResults ucInventorySearchResults;
        private readonly InventorySearchResults inventorySearchResults;
        private readonly string ConnectionString;
        public static string applicationPath = AppDomain.CurrentDomain.BaseDirectory;

        public InventorySearchResultsPresenter(UCInventorySearchResults isr)
        {
            ucInventorySearchResults = isr;
            inventorySearchResults = new InventorySearchResults();
            ConnectionString = ConfigurationManager.ConnectionStrings["ProductManager.Properties.Settings.BTDataConnectionString"].ConnectionString;

            // Query DB using search string, populate inventorySearchResults.InventoryItems
            EventAggregator.Instance.Subscribe<InventoryProductSearch>(OnSearchTextChanged);            
        }

        private void OnSearchTextChanged(InventoryProductSearch ps)
        {
            if (ps.SearchString.Length == 0)
                return;

            ucInventorySearchResults.Focus();

            int found = 0;
            //var tempfile = applicationPath + @"..\..\Images\temp.jpg";
            var tempfile = @"..\..\Images\temp.jpg";
            using (SqlConnection conn = new SqlConnection())
            {
                inventorySearchResults.InventoryItems.Clear();

                // Create the connectionString (Trusted_Connection is used to denote the connection uses Windows Authentication)
                //conn.ConnectionString = "Server=MEGATRON\\SQLEXPRESS;Database=TTBDB;Trusted_Connection=true";
                //conn.ConnectionString = "Server=MEGATRON\\SQLEXPRESS;Database=TTBDB;Trusted_Connection=true";
                conn.ConnectionString = ConnectionString;
                conn.Open();

                // Create the command
                SqlCommand command = new SqlCommand(
                    "SELECT top 18 * " + //sku, title, variation, cost, Location as binrack, image_url " +
                      "FROM Inventory " +
                      "WHERE (title like @titleSearch or sku like @skuSearch or upc like @upcSearch) and active=1", 
                    conn);

                // Add the parameters.
                command.Parameters.Add(new SqlParameter("titleSearch", "%" + ps.SearchString + "%"));
                command.Parameters.Add(new SqlParameter("skuSearch", "%" + ps.SearchString + "%"));
                command.Parameters.Add(new SqlParameter("upcSearch", "%" + ps.SearchString + "%"));

                // Execute command and read results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        found++;
                        var inventoryItem = new InventoryItem();
                        inventoryItem.SKU = reader["SKU"].ToString();
                        inventoryItem.Title = reader["Title"].ToString();
                        inventoryItem.Variation = reader["Variation"].ToString();
                        inventoryItem.BinRack = reader["Location"].ToString();
                        inventoryItem.Cost = reader["cost"].ToString();
                        inventoryItem.Supplier = reader["supplier"].ToString();
                        inventoryItem.Weight = (int)reader["weight"];
                        inventoryItem.UPC = reader["UPC"].ToString();

                        var url = reader["image_url"].ToString();

                        using (var wc = new WebClient())
                        {
                            // Don't keep reloading the picture
                            try
                            {
                                wc.DownloadFile(url, tempfile);
                            }
                            catch
                            { 
                                File.Copy(@"..\..\Images\missing.jpg", tempfile);
                            }

                            using (Image tempimg = Image.FromFile(tempfile))
                            {
                                inventoryItem.PrimaryPicture = new Bitmap(tempimg);
                            }

                            inventorySearchResults.InventoryItems.Add(inventoryItem);
                        }

                    } // while(reader.Read()))
                } // using( SQLDataReader

            } // sqlconnection
            System.IO.File.Delete(tempfile);

            if (found == 0)
            {
                EventAggregator.Instance.Publish(new SpeechBubble { Text = "No Results found" });
            }

            // Display search results
            string foundMsg = $"found {found} products";
            if ( found == 1 )
            {
                foundMsg = $"found {found} product";
            }
            else if ( found >= 18 )
            {
                foundMsg = $"found 18 or more products";
            }
            EventAggregator.Instance.Publish(new SpeechBubble { Text = foundMsg });

            ucInventorySearchResults.DisplaySearchResults(inventorySearchResults);

            // Go directory to the Product Details screen, if 
            //   1. Only one item is found
            //   2. a UPC is searched for and found
            bool gotoProductDetailsScreen = false;
            if ( found == 1 )
            {
                gotoProductDetailsScreen = true;
            }
            else if ( found > 1 && Regex.IsMatch(ps.SearchString, @"^\d{8,}$") )
            {
                var titleCount = new Dictionary<string, int>();

                foreach (InventoryItem i in inventorySearchResults.InventoryItems)
                {
                    if (!titleCount.ContainsKey(i.Title))
                        titleCount.Add(i.Title, 1);
                }

                if(titleCount.Keys.Count==1)
                    gotoProductDetailsScreen = true;
            }

            if (gotoProductDetailsScreen )
            {
                EventAggregator.Instance.Publish(new InventoryProductDetails { inventoryItem = (InventoryItem) inventorySearchResults.InventoryItems[0] });
                EventAggregator.Instance.Publish(new InventoryShowProductEditorView());
            }
        }
    }
}
