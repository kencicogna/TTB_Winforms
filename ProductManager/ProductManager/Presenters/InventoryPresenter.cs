using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManager.Views;
using ProductManager.Models;
using ProductManager.Events;
using System.Data.SqlClient;
using System.Net;
using System.Threading;
using System.Drawing;
using System.IO;

namespace ProductManager.Presenters
{
    class InventoryPresenter
    {
        private readonly IInventoryView inventoryView;
        private readonly InventorySearchResults inventorySearchResults;

        public InventoryPresenter(IInventoryView iv)
        {
            inventoryView = iv;
            inventorySearchResults = new InventorySearchResults();

            EventAggregator.Instance.Subscribe<InventoryShowSearchResultView>(OnBtnShowSearchResultsView_Click);
            EventAggregator.Instance.Subscribe<InventoryShowProductEditorView>(OnBtnShowProductView_Click);
            EventAggregator.Instance.Subscribe<InventoryProductSearch>(OnSearchTextChanged);            
            EventAggregator.Instance.Subscribe<InventoryProductDetails>(OnDisplayProductDetails);

        }

        //private void DisplaySearchResults(InventorySearchResult obj)
        //{
        //    inventoryView.DisplaySearchResults
        //}

        private void OnSearchTextChanged(InventoryProductSearch ps)
        {
            if (ps.SearchString.Length == 0)
                return;

            var tempfile = @"..\..\Images\temp.jpg";
            using (SqlConnection conn = new SqlConnection())
            {
                //if (inventorySearchResults.InventoryItems.Count() > 0)
                inventorySearchResults.InventoryItems.Clear();

                // Create the connectionString
                // Trusted_Connection is used to denote the connection uses Windows Authentication
                conn.ConnectionString = "Server=KEN-LAPTOP\\SQLEXPRESS;Database=BTData;Trusted_Connection=true";
                //conn.ConnectionString = "Server=MEGATRON\\SQLEXPRESS;Database=TTBDB;Trusted_Connection=true";
                conn.Open();

                // Create the command
                SqlCommand command = new SqlCommand("SELECT top 3 sku, title, variation, cost, Location as binrack, image_url FROM Inventory WHERE title like @titleSearch or sku like @skuSearch", conn);

                // Add the parameters.
                command.Parameters.Add(new SqlParameter("titleSearch", "%" + ps.SearchString + "%"));
                command.Parameters.Add(new SqlParameter("skuSearch", "%" + ps.SearchString + "%"));

                // Execute command and read results
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var inventoryItem = new InventoryItem();
                        inventoryItem.SKU = reader[0].ToString();
                        inventoryItem.Title = reader[1].ToString();
                        inventoryItem.Variation = reader[2].ToString();
                        inventoryItem.BinRack = reader[3].ToString();
                        inventoryItem.Cost = reader[4].ToString();

                        var url = reader[5].ToString();

                        using (var wc = new WebClient())
                        {
                            // Don't keep reloading the picture
                            Thread.Sleep(2000);

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
                                inventoryItem.Title = reader[1].ToString();
                            }

                            inventorySearchResults.InventoryItems.Add(inventoryItem);
                        }

                    } // while(reader.Read()))
                } // using( SQLDataReader

            } // sqlconnection
            System.IO.File.Delete(tempfile);

            inventoryView.DisplaySearchResults(inventorySearchResults);
        }

        private void OnBtnShowSearchResultsView_Click(InventoryShowSearchResultView obj)
        {
            inventoryView.ShowSearchResultsView();
        }

        private void OnBtnShowProductView_Click(InventoryShowProductEditorView obj)
        {
            inventoryView.ShowProductEditorView();
        }

        private void OnDisplayProductDetails(InventoryProductDetails obj)
        {
            inventoryView.ShowProductEditorView();

        }

        public void OnSearchTextChanged(InventoryShowSearchResultView inventorySearch)
        {
            // use is.SearchString to query db and return result to the view
        }
    }
}
