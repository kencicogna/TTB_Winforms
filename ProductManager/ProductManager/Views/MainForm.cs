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

namespace ProductManager.Views
{
    public interface IMainFormView
    {
        void AddInventoryView();
    }

    public partial class MainForm : Form, IMainFormView
    {
        private readonly Control inventoryView;

        internal void SetStatus(string statusText)
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
    }
}
