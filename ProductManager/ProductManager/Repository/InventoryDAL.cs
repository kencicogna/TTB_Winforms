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
using System.Windows.Forms;
using System.Configuration;

namespace ProductManager.Repository
{
    class InventoryDAL
    {
        public InventoryItem InventoryItemList { get; set; }
        private readonly string ConnectionString;

        public InventoryDAL()
        {
            // TODO: this is a little deceptive, an item will not always have variations, 
            //       but the item is still stored in VariationItems list.
            // List of Items (held in the VariationsItems property) 
            InventoryItemList = new InventoryItem();
            ConnectionString = ConfigurationManager.ConnectionStrings["ProductManager.Properties.Settings.BTDataConnectionString"].ConnectionString;

        }

        public InventoryItem GetAllVariations(InventoryItem parentItem)
        {
            // Clear out list of items
            InventoryItemList.VariationItems.Clear();

            var tempfile = @"..\..\Images\temp.jpg";
            using (SqlConnection conn = new SqlConnection())
            {
                //inventorySearchResults.InventoryItems.Clear();

                // Create the connectionString
                // Trusted_Connection is used to denote the connection uses Windows Authentication
                //conn.ConnectionString = "Server=192.168.0.17,50088;Initial Catalog=BTData;Network Library=DBMSSOCN;User ID=shipit2;Password=shipit2";
                //conn.ConnectionString = "Server=KEN-LAPTOP\\SQLEXPRESS;Database=BTData;Trusted_Connection=true";
                //conn.ConnectionString = "Server=MEGATRON\\SQLEXPRESS;Database=TTBDB;Trusted_Connection=true";
                conn.ConnectionString = ConnectionString;
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

                            InventoryItemList.VariationItems.Add(inventoryItem);
                        }

                    } // while(reader.Read()))
                } // using( SQLDataReader

            } // sqlconnection
            System.IO.File.Delete(tempfile);

            return InventoryItemList;
        }

        //internal void UpdateDB(InventoryItem inventoryItems)
        internal void UpdateDB(DataGridView dgv)
        {
            int rowsUpdatedCount = 0;

            using (SqlConnection conn = new SqlConnection())
            {
                // Create the connectionString (Trusted_Connection = Windows Authentication)
                //conn.ConnectionString = "Server=192.168.0.17,50088;Initial Catalog=BTData;Network Library=DBMSSOCN;User ID=shipit2;Password=shipit2";
                //conn.ConnectionString = "Server=KEN-LAPTOP\\SQLEXPRESS;Database=BTData;Trusted_Connection=true";
                //conn.ConnectionString = "Server=MEGATRON\\SQLEXPRESS;Database=TTBDB;Trusted_Connection=true";
                conn.ConnectionString = ConnectionString;
                conn.Open();

                // Create the command
                SqlCommand command = new SqlCommand(
                    "UPDATE Inventory " +
                    "SET Location=@Location, Cost=@Cost, Supplier=@Supplier, Weight=@Weight, UPC=@UPC, Last_modified=SYSDATETIME()" +
                      "WHERE SKU = @SKU and active=1",
                    conn);

                // Add the parameters.
                command.Parameters.Add(new SqlParameter("@Location", ""));
                command.Parameters.Add(new SqlParameter("@Cost", ""));
                command.Parameters.Add(new SqlParameter("@Supplier", ""));
                command.Parameters.Add(new SqlParameter("@Weight", ""));
                command.Parameters.Add(new SqlParameter("@UPC", ""));
                command.Parameters.Add(new SqlParameter("@SKU", ""));

                //foreach (var item in inventoryItems.VariationItems)
                foreach (DataGridViewRow item in dgv.Rows)
                {
                    command.Parameters["@Location"].Value = item.Cells["Location"].Value?.ToString() ?? "";
                    command.Parameters["@Cost"].Value = item.Cells["Cost"].Value?.ToString() ?? "";
                    command.Parameters["@Supplier"].Value = item.Cells["Supplier"].Value?.ToString() ?? "";
                    command.Parameters["@Weight"].Value = item.Cells["Weight"].Value?.ToString() ?? "";
                    command.Parameters["@UPC"].Value = item.Cells["UPC"].Value?.ToString() ?? "";
                    command.Parameters["@SKU"].Value = item.Cells["SKU"].Value?.ToString() ?? "";

                    rowsUpdatedCount = command.ExecuteNonQuery();


                    if ( rowsUpdatedCount != 1 )
                    {
                        throw new Exception(rowsUpdatedCount+" Rows updated for SKU='" + item.Cells["SKU"] + "'");
                    }
                    //else
                    //{
                    //    MessageBox.Show("Row Updated = '" + rowsUpdatedCount + "'");
                    //}

                }

            } // sqlconnection

        } // UpdateDB

    } // class
} // namespace
