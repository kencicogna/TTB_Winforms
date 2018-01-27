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
using ProductManager.Presenters.Inventory;

namespace ProductManager.Views.Inventory
{
    public interface IInventoryProductEditor
    {
    }

    public partial class UCInventoryProductEditor : UserControl, IInventoryProductEditor
    {
        public InventoryProductEditorPresenter presenter { get; set; }

        public UCInventoryProductEditor()
        {
            InitializeComponent();
            dgvProductDetails.DefaultCellStyle.SelectionBackColor = Color.AliceBlue;
            dgvProductDetails.DefaultCellStyle.SelectionForeColor = Color.Black;
        }

        public DataGridView GetDataGridView()
        {
            return dgvProductDetails;
        }

        private void dgvProductDetails_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int row = e.RowIndex;
            if (row >= 0)
            {
                dgvProductDetails.Rows[row].Selected = true;
            }
        }

        private void dgvProductDetails_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int row = e.RowIndex;
            if (row >= 0)
            { 
                dgvProductDetails.Rows[row].Selected = false;
            }
        }

        private void dgvProductDetails_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            int row = e.RowIndex;
            int col = e.ColumnIndex;
            string cellValue = dgvProductDetails.Rows[row].Cells[col].Value?.ToString();
            string sku = dgvProductDetails.Rows[row].Cells["SKU"].Value?.ToString();

            presenter.updateGrid(row,col,cellValue);
        }

        internal void AddCellChangedEventHandler()
        {
            dgvProductDetails.CellValueChanged += dgvProductDetails_CellValueChanged;
        }

        internal void RemoveCellChangedEventHandler()
        {
            dgvProductDetails.CellValueChanged -= dgvProductDetails_CellValueChanged;
        }
    }
}
