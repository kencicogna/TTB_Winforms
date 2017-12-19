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

namespace ProductManager.Views.Inventory
{
    public interface IInventorySearchBar
    {
    }

    public partial class UCInventorySearchBar : UserControl, IInventorySearchBar
    {
        Timer timer;
        private int ticker = 0;
        private int tickerLimit = 2;
        private bool readyToSearch = false;

        public UCInventorySearchBar()
        {
            InitializeComponent();

            // Set up a timer to check for keystokes (we want a brief delay before starting a search)
            timer = new Timer { Interval = 1000 };
            timer.Tick += TimerOnTick;
            timer.Start();

        }

        private void TimerOnTick(object sender, EventArgs eventArgs)
        {
            if (readyToSearch)
            {
                if (ticker >= tickerLimit)
                {
                    // Trigger Search Event
                    EventAggregator.Instance.Publish(new InventoryProductSearch { SearchString = tbSearch.Text });
                    readyToSearch = false;
                }
                else
                {
                    ticker++;
                }
            }
        }

        private void tbSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && tbSearch.Text.Length > 0 && readyToSearch)
            {
                EventAggregator.Instance.Publish(new InventoryProductSearch { SearchString = tbSearch.Text });
                readyToSearch = false;
            }

        }

        private void tbSearch_TextChanged(object sender, EventArgs e)
        {
            ticker = 0;
            if (tbSearch.Text.Length > 0)
                readyToSearch = true;
        }

        private void btnShowSearchResultsView_Click(object sender, EventArgs e)
        {
            EventAggregator.Instance.Publish(new InventoryShowSearchResultView());
        }

        private void btnShowProductView_Click(object sender, EventArgs e)
        {
            EventAggregator.Instance.Publish(new InventoryShowProductEditorView());
        }

        private void UCInventorySearchBar_Load(object sender, EventArgs e)
        {
            //tbSearch.Focus();
        }

        public void SetSearchBoxFocus()
        {
            this.tbSearch.Focus();
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            //EventAggregator.Instance.Publish(new InventoryShowSearchResultView());
        }
    }
}
