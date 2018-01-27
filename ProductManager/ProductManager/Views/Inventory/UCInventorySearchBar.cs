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
                    EventAggregator.Instance.Publish(new SpeechBubble { Text = "Searching for products..." });
                    System.Threading.Thread.Sleep(2000);
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
                EventAggregator.Instance.Publish(new SpeechBubble { Text = "Searching for products..." });
                System.Threading.Thread.Sleep(2000);
                EventAggregator.Instance.Publish(new InventoryProductSearch { SearchString = tbSearch.Text });
                readyToSearch = false;
            }

        }

        public void SetSearchBoxTextColorNormal()
        {
            tbSearch.ForeColor = Color.Black;
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
        }

        public void SetSearchBoxFocus()
        {
            this.tbSearch.Focus();
        }

        private void tbSearch_Enter(object sender, EventArgs e)
        {
            //EventAggregator.Instance.Publish(new InventoryShowSearchResultView());
            tbSearch.Focus();
            tbSearch.SelectAll();
        }

        private void tbSearch_Click(object sender, EventArgs e)
        {
            tbSearch.Focus();
            tbSearch.SelectAll();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("search bar btnSave_Click...");
            EventAggregator.Instance.Publish(new InventoryProductEditorSave());
        }

        private void btnLockColumns_Click(object sender, EventArgs e)
        {
            string tag = pbLockColumns.Tag.ToString();
            if ( tag.Equals("Unlocked") == true)
            {
                pbLockColumns.BackgroundImage = Image.FromFile("..\\..\\Images\\icons\\Lock30.png");
                btnLockColumns.Text = "Unlock Columns";
                pbLockColumns.Tag = "Locked";
                EventAggregator.Instance.Publish(new InventoryProductEditorLockColumns { locked = true });
            }
            else
            {
                pbLockColumns.BackgroundImage = Image.FromFile("..\\..\\Images\\icons\\Unlock30.png");
                btnLockColumns.Text = "Lock Columns";
                pbLockColumns.Tag = "Unlocked";
                EventAggregator.Instance.Publish(new InventoryProductEditorLockColumns { locked = false });
            }
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            EventAggregator.Instance.Publish(new InventoryProductEditorUndoChanges());
        }
    }
}
