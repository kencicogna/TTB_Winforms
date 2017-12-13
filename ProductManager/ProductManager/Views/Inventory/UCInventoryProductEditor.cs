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
        InventoryProductEditorPresenter presenter;

        public UCInventoryProductEditor()
        {
            InitializeComponent();
            presenter = (InventoryProductEditorPresenter)this.Tag;
        }

        public DataGridView GetDataGridView()
        {
            return dgvProductDetails;
        }

        private void dgvProductDetails_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int row = e.RowIndex;
            if (row>=0)
              dgvProductDetails.Rows[row].Selected = true;
        }

        private void dgvProductDetails_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            int column = e.ColumnIndex;
            int row = e.RowIndex;
            if (row>=0)
            dgvProductDetails.Rows[row].Selected = false;
        }
    }
}
