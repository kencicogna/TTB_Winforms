using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using ProductManager.Models;
using System.Net;
using System.Drawing;
using System.IO;

namespace ProductManager.Repository
{
    class InventoryDAL
    {
        public InventoryItem inventoryItemList { get; set; }
        public InventoryDAL()
        {
            // TODO: this is a little deceptive, an item will not always have variations, 
            //       but the item is still stored in VariationItems list.
            // List of Items (held in the VariationsItems property) 
            inventoryItemList = new InventoryItem();
        }

        public InventoryItem GetAllVariations(InventoryItem parentItem)
        {
            // Clear out list of items
            inventoryItemList.VariationItems.Clear();

            var tempfile = @"..\..\Images\temp.jpg";
            using (SqlConnection conn = new SqlConnection())
            {
                //inventorySearchResults.InventoryItems.Clear();

                // Create the connectionString
                // Trusted_Connection is used to denote the connection uses Windows Authentication
                conn.ConnectionString = "Server=KEN-LAPTOP\\SQLEXPRESS;Database=BTData;Trusted_Connection=true";
                //conn.ConnectionString = "Server=MEGATRON\\SQLEXPRESS;Database=TTBDB;Trusted_Connection=true";
                conn.Open();

                // Create the command
                SqlCommand command = new SqlCommand(
                    "SELECT *" +
                      "FROM Inventory " +
                      "WHERE title = @titleSearch",
                    conn);

                // Add the parameters.
                command.Parameters.Add(new SqlParameter("titleSearch", parentItem.Title));

                // Execute command and read results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
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
                                //inventoryItem.Title = reader[1].ToString();
                            }

                            inventoryItemList.VariationItems.Add(inventoryItem);
                        }

                    } // while(reader.Read()))
                } // using( SQLDataReader

            } // sqlconnection
            System.IO.File.Delete(tempfile);

            return inventoryItemList;
        }
    }
}
