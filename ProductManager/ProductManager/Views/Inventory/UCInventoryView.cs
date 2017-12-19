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

namespace ProductManager.Views.Inventory
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
        void DisplayResultsInProductEditor(InventorySearchResults inventorySearchResults);
        //void DisplaySearchResults(InventorySearchResults i);
    }

    public partial class UCInventoryView : UserControl, IInventoryView
    {
        private readonly Control inventorySearchBar;
        private readonly Control inventorySearchResults;
        private readonly Control inventoryProductEditor;

        public UCInventoryView(Control isb, Control isr, Control ipe)
        {
            InitializeComponent();

            inventorySearchBar = isb;
            inventorySearchBar.Dock = DockStyle.Fill;
            pnlSeachBarContainer.Controls.Clear();
            pnlSeachBarContainer.Controls.Add(inventorySearchBar);

            inventorySearchResults = isr;
            inventorySearchResults.Dock = DockStyle.Fill;
            ShowSearchResultsView();

            inventoryProductEditor = ipe;
            inventoryProductEditor.Dock = DockStyle.Fill;
        }

        public void ShowSearchResultsView()
        {
            if (pnlSearchResultsContainer.Controls.Count == 0)
            {
                pnlSearchResultsContainer.Controls.Add(inventorySearchResults);
            }
            else if (pnlSearchResultsContainer.Controls[0].GetType().Name != "UCInventorySearchResults")
            {
                pnlSearchResultsContainer.Controls.Clear();
                pnlSearchResultsContainer.Controls.Add(inventorySearchResults);
            }
        }

        public void ShowProductEditorView()
        {
            if (pnlSearchResultsContainer.Controls.Count == 0)
            {
                pnlSearchResultsContainer.Controls.Add(inventoryProductEditor);
            }
            else if (pnlSearchResultsContainer.Controls[0].GetType().Name != "UCInventoryProductEditor")
            {
                pnlSearchResultsContainer.Controls.Clear();
                pnlSearchResultsContainer.Controls.Add(inventoryProductEditor);
            }
        }

        private void UCInventoryView_Load(object sender, EventArgs e)
        {
            //(UCInventorySearchBar)inventorySearchBar.SetSearchBoxFocus();
        }

        public void DisplayResultsInProductEditor(InventorySearchResults inventorySearchResults)
        {
            throw new NotImplementedException();
        }
    }
}
