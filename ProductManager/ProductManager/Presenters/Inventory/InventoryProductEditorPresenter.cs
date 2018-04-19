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
using CloneExtensions;
using System.Threading;

namespace ProductManager.Presenters.Inventory
{
    public class InventoryProductEditorPresenter
    {
        private UCInventoryProductEditor inventoryProductEditor;
        private readonly InventoryDAL inventoryDAL;
        private InventoryItem inventoryItems;
        private InventoryItem inventoryItemsOrig;
        private bool lockColumns;

        public InventoryProductEditorPresenter(UCInventoryProductEditor ipe)
        {
            inventoryProductEditor = ipe;

            inventoryDAL = new InventoryDAL();
            inventoryItems = new InventoryItem();
            inventoryItemsOrig = new InventoryItem();

            // Image Clicked
            EventAggregator.Instance.Subscribe<InventoryProductDetails>(OnParentProductSelected);
            EventAggregator.Instance.Subscribe<InventoryProductEditorLockColumns>( SetLockColumns );
            EventAggregator.Instance.Subscribe<InventoryProductEditorSave>( UpdateDB );
            EventAggregator.Instance.Subscribe<InventoryProductEditorUndoChanges>( UndoChanges );
        }

        private void UndoChanges(InventoryProductEditorUndoChanges obj)
        {
            //
            // NOTE: We don't really need the clone. I think we can just pass "inventoryItems", since I'm not
            //       updating the class as the datagrid gets updated.
            //
            inventoryItems = inventoryItemsOrig.Clone();
            PopulateDataGridView(inventoryItems);
        }

        public void ShowSplashScreen()
        {
                Application.Run(new formSplashScreen());
        }

        private void UpdateDB(InventoryProductEditorSave obj)
        {
            var dgvProductDetails = inventoryProductEditor.GetDataGridView();

            try
            {
                inventoryDAL.UpdateDB(dgvProductDetails);
                //MessageBox.Show("Change Saved!");
                Thread t = new Thread(new ThreadStart(ShowSplashScreen));
                t.Start();
                Thread.Sleep(1500);
                t.Abort();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Save Failed! " + ex.ToString());
            }
        }

        private void SetLockColumns(InventoryProductEditorLockColumns obj)
        {
            lockColumns = obj.locked;
        }

        public void OnParentProductSelected(InventoryProductDetails selectedItem)
        {
            // query db, get all variations for this item
            inventoryItems = inventoryDAL.GetAllVariations(selectedItem.inventoryItem);
            inventoryItemsOrig = inventoryItems.Clone();

            PopulateDataGridView(inventoryItems);
        }

        public void PopulateDataGridView(InventoryItem inventoryItems)
        {
            var dgvProductDetails = inventoryProductEditor.GetDataGridView();

            // populate the product editor view
            if (inventoryItems.VariationItems.Count > 0)
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
                    dgvProductDetails.Columns.Add("Cost","Cost");
                    dgvProductDetails.Columns.Add("Supplier", "Supplier");
                    dgvProductDetails.Columns.Add("Weight", "Weight");
                    dgvProductDetails.Columns.Add("UPC", "UPC");
                    dgvProductDetails.Columns.Add("Location", "Location");

                    dgvProductDetails.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                    dgvProductDetails.Columns["Title"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    dgvProductDetails.Columns["SKU"].ReadOnly = true;
                    dgvProductDetails.Columns["Title"].ReadOnly = true;
                    dgvProductDetails.Columns["Variation"].ReadOnly = true;
                }

                dgvProductDetails.Rows.Clear();
                dgvProductDetails.RowTemplate.Height = 100;

                // Add data rows
                foreach (InventoryItem i in inventoryItems.VariationItems)
                {
                    Image thumb = i.PrimaryPicture.GetThumbnailImage(100, 100, null, IntPtr.Zero);
                    dgvProductDetails.Rows.Add(thumb, i.SKU, i.Variation, i.Title, i.Cost, i.Supplier, i.Weight, i.UPC, i.Location);
                }
                dgvProductDetails.RowHeadersVisible = false;
                dgvProductDetails.ColumnHeadersVisible = true;
            }
            else
            {
                MessageBox.Show("Error... OnParentProductSelected()");
            }

            dgvProductDetails.Focus();
        }

        internal void updateGrid(int row, int col, string val)
        {
            if (lockColumns == false) return;

            var dgv= inventoryProductEditor.GetDataGridView();

            // Temporarily remove event handler
            inventoryProductEditor.RemoveCellChangedEventHandler();

            for (int r = 0; r < dgv.RowCount; r++)
            {
                if (r==row) continue; // skip current row
                dgv.Rows[r].Cells[col].Value = val;
            }

            // Restore event handler
            inventoryProductEditor.AddCellChangedEventHandler();
        }

    }
}
