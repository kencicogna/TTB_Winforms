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

namespace ProductManager.Views
{
    public interface IInventorySearchBar
    {

    }

    public partial class UCInventorySearchBar : UserControl, IInventorySearchBar
    {
        public UCInventorySearchBar()
        {
            InitializeComponent();
        }

        private void btnShowSearchResultsView_Click(object sender, EventArgs e)
        {
            EventAggregator.Instance.Publish(new InventoryShowSearchResultView() );
        }

        private void btnShowProductView_Click(object sender, EventArgs e)
        {
            EventAggregator.Instance.Publish(new InventoryShowProductEditorView());
        }
    }
}
