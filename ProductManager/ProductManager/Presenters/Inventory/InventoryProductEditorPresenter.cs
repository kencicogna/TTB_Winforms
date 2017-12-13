using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManager.Views.Inventory;
using ProductManager.Events;
using ProductManager.Repository;
using ProductManager.Models;
using System.Windows.Forms;
using System.Drawing;

namespace ProductManager.Presenters.Inventory
{
    public class InventoryProductEditorPresenter
    {
        private UCInventoryProductEditor inventoryProductEditor;
        private readonly InventoryDAL inventoryDAL;
        private InventoryItem inventoryItems;

        public InventoryProductEditorPresenter(UCInventoryProductEditor ipe)
        {
            inventoryProductEditor = ipe;

            inventoryDAL = new InventoryDAL();
            inventoryItems = new InventoryItem();

            // Image Clicked
            EventAggregator.Instance.Subscribe<InventoryProductDetails>(OnParentProductSelected);
        }

        public void OnParentProductSelected(InventoryProductDetails selectedItem)
        {
            var dgvProductDetails = inventoryProductEditor.GetDataGridView();

            //dgvProductDetails.CellMouseEnter += new DataGridViewCellEventHandler(dgvProductDetails_CellMouseEnter);
            //dgvProductDetails.CellMouseLeave += new DataGridViewCellEventHandler(dgvProductDetails_CellMouseLeave);

            // query db, get all variations for this item
            InventoryItem allItems = inventoryDAL.GetAllVariations(selectedItem.inventoryItem);

            // populate the product editor view; publish InventoryProductDetailsLineItems
            if (allItems != null)
            {
                // TODO: I'm guessing this is not the right place for this
                if (dgvProductDetails.Columns.Count == 0)
                {
                    var imageCol = new DataGridViewImageColumn();
                    imageCol.Width = 100;
                    dgvProductDetails.Columns.Add(imageCol);
                    dgvProductDetails.Columns.Add("SKU", "SKU");
                    dgvProductDetails.Columns.Add("Variation", "Variation");
                    dgvProductDetails.Columns.Add("Title", "Title");
                    dgvProductDetails.Columns.Add("Cost", "Cost");
                    dgvProductDetails.Columns.Add("Supplier", "Supplier");
                    dgvProductDetails.Columns.Add("Weight", "Weight");
                    dgvProductDetails.Columns.Add("UPC", "UPC");
                    dgvProductDetails.Columns.Add("Location", "Location");
                    dgvProductDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgvProductDetails.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }

                dgvProductDetails.Rows.Clear();
                dgvProductDetails.RowTemplate.Height = 100;
                foreach (InventoryItem i in allItems.VariationItems)
                {
                    Image thumb = i.PrimaryPicture.GetThumbnailImage(100, 100, null, IntPtr.Zero);

                    dgvProductDetails.Rows.Add(thumb, i.SKU, i.Variation, i.Title, i.Cost, i.Supplier, i.Weight, i.UPC, i.Location);
                }
                dgvProductDetails.RowHeadersVisible = false;
                dgvProductDetails.ColumnHeadersVisible = true;
            }
            else
            {
                System.Windows.Forms.MessageBox.Show("Test");
            }

            dgvProductDetails.Focus();
        }

    }
}
