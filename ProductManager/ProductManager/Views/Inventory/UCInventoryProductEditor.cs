using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManager.Events;
using ProductManager.Models;

namespace ProductManager.Views
{
    public interface IInventoryProductEditor
    {
    }

    public partial class UCInventoryProductEditor : UserControl, IInventoryProductEditor
    {
        public UCInventoryProductEditor()
        {
            InitializeComponent();
            EventAggregator.Instance.Subscribe<InventoryProductDetailsLineItems>(OnProductDetailsAddItem);
        }

        public void OnProductDetailsAddItem(InventoryProductDetailsLineItems resultSet)
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
            foreach (InventoryItem i in resultSet.inventoryItems)
            {
                Image thumb = i.PrimaryPicture.GetThumbnailImage(100, 100, null, IntPtr.Zero);

                dgvProductDetails.Rows.Add(thumb, i.SKU, i.Variation, i.Title, i.Cost, i.Supplier, i.Weight, i.UPC, i.Location);
            }
            dgvProductDetails.RowHeadersVisible = false;
            dgvProductDetails.ColumnHeadersVisible = true;

        }

        private void dgvProductDetails_MouseEnter(object sender, EventArgs e)
        {
            //var dgvcea = (DataGridViewCellEventArgs)e;
            int column = 1; //e.ColumnIndex;
            int row = 1; //e.RowIndex;
            if (row > 0)
                dgvProductDetails.Rows[row].Selected = true;
        }
    }
}
