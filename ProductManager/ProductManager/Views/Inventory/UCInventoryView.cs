using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManager.Models;

namespace ProductManager.Views
{
    public interface IInventoryView
    {
        //String BinRack { get; set; }
        //String Cost { get; set; }
        //Image PrimaryPicture { get; set; }
        //String PrimaryPictureURL { get; }
        //String SKU { get; set; }
        //String Title { get; set; }
        //String Variations { get; set; }
        void ShowSearchResultsView();
        void ShowProductEditorView();
        void DisplaySearchResults(InventorySearchResults i);
    }

    public partial class UCInventoryView : UserControl, IInventoryView
    {
        private readonly Control inventorySearchResults;
        private readonly Control inventoryProductEditor;

        public UCInventoryView(Control isr, Control ipe)
        {
            InitializeComponent();

            inventorySearchResults = isr;
            inventoryProductEditor = ipe;
            inventoryProductEditor.Dock = DockStyle.Fill;

            ShowSearchResultsView();
        }

        public void ShowSearchResultsView()
        {
            pnlSearchResultsContainer.Show();
            pnlProductEditorContainer.Hide();
        }

        public void ShowProductEditorView()
        {
            pnlProductEditorContainer.Show();
            pnlSearchResultsContainer.Hide();
        }

        public void DisplaySearchResults(InventorySearchResults inventorySearchResults)
        {
            ucInventorySearchResults.DisplaySearchResults(inventorySearchResults);
        }

        private void UCInventoryView_Load(object sender, EventArgs e)
        {
            inventorySearchResults.SetSearchBoxFocus();
        }
    }
}
