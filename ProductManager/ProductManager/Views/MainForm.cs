using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManager.Presenters;
using ProductManager.Events;

namespace ProductManager.Views
{
    public interface IMainFormView
    {
        void AddInventoryView();
    }

    public partial class MainForm : Form, IMainFormView
    {
        private readonly Control inventoryView;

        public void SetStatus(string statusText)
        {
            lblMainHeaderStatus.Text = statusText;
        }

        public MainForm(Control inventoryView)
        {
            InitializeComponent();
            this.inventoryView = inventoryView;
            this.inventoryView.Dock = DockStyle.Fill;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AddInventoryView();
        }

        public void AddInventoryView()
        {
            tabPageMainInventory.Controls.Clear();
            tabPageMainInventory.Controls.Add(inventoryView);
        }

        private void tabControlMain_Selected(object sender, TabControlEventArgs e)
        {
            if (tabControlMain.SelectedTab.Text == "Inventory")
            {
                pbAvatar.ImageLocation = @"..\..\Images\racoon.jpg";
            }
            else if (tabControlMain.SelectedTab.Text == "Shipping")
            {
                pbAvatar.ImageLocation = @"..\..\Images\fox.png";
            }
            else if (tabControlMain.SelectedTab.Text == "PickList")
            {
                pbAvatar.ImageLocation = @"..\..\Images\dear.png";
            }
            else if (tabControlMain.SelectedTab.Text == "Settings")
            {
                pbAvatar.ImageLocation = @"..\..\Images\owl.png";
            }

        }

        private void pbMenuInventory_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 0;
            lblMainHeaderStatus.Text = "Enter SKU, UPC, or any part of Title to search for products.";

            EventAggregator.Instance.Publish(new InventoryPageSetup());
        }

        private void pbMenuShipping_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 1;
            lblMainHeaderStatus.Text = "Welcome to the shipping application.";
        }

        private void pbMenuPickList_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 2;
            lblMainHeaderStatus.Text = "Pick the items belows in the order specified.";
        }

        private void pbMenuSettings_Click(object sender, EventArgs e)
        {
            tabControlMain.SelectedIndex = 3;
            lblMainHeaderStatus.Text = "Adjust the application settings here.";
        }

        private void pbMenuInventory_MouseEnter(object sender, EventArgs e)
        {
            pbMenuInventory.BackColor = Color.SkyBlue;
            //pbMenuInventory.ImageLocation = @"..\..\Images\icons\inventory icon 10.png";
        }

        private void pbMenuInventory_MouseLeave(object sender, EventArgs e)
        {
            pbMenuInventory.BackColor = Color.Transparent;
            //pbMenuInventory.ImageLocation = @"..\..\Images\icons\inventory icon.png";
        }

        private void pbMenuShipping_MouseEnter(object sender, EventArgs e)
        {
            pbMenuShipping.BackColor = Color.SkyBlue;
        }

        private void pbMenuShipping_MouseLeave(object sender, EventArgs e)
        {
            pbMenuShipping.BackColor = Color.Transparent;
        }

        private void pbMenuPickList_MouseEnter(object sender, EventArgs e)
        {
            pbMenuPickList.BackColor = Color.SkyBlue;
        }

        private void pbMenuPickList_MouseLeave(object sender, EventArgs e)
        {
            pbMenuPickList.BackColor = Color.Transparent;
        }

        private void pbMenuSettings_MouseEnter(object sender, EventArgs e)
        {
            pbMenuSettings.BackColor = Color.SkyBlue;
        }

        private void pbMenuSettings_MouseLeave(object sender, EventArgs e)
        {
            pbMenuSettings.BackColor = Color.Transparent;
        }
    }
}
