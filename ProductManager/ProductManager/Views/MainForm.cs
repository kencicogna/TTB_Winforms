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
        //        event EventHandler Load;
        //        event HelpEventHandler HelpRequested;
        //        event KeyEventHandler KeyUp;

        void AddInventoryView();
    }

    public partial class MainForm : Form, IMainFormView
    {
        private readonly Control inventoryView;
        //private readonly MainFormPresenter presenter;   // set .Tag property

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

    }
}
