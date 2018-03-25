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
        void ShowSearchResultsView();
        void ShowProductEditorView();
        void DisplayResultsInProductEditor(InventorySearchResults inventorySearchResults);
    }

    public partial class UCInventoryView : UserControl, IInventoryView
    {
        private readonly UCInventorySearchBar inventorySearchBar;
        private readonly Control inventorySearchResults;
        private readonly Control inventoryProductEditor;

        public UCInventoryView(UCInventorySearchBar isb, Control isr, Control ipe)
        {
            InitializeComponent();

            inventorySearchBar = isb;
            inventorySearchBar.Dock = DockStyle.Fill;
            inventorySearchBar.SetSearchBoxTextColorNormal();

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
            // TODO: pass object name and use a 'get type' method instead of Control[0]......
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
        }

        public void DisplayResultsInProductEditor(InventorySearchResults inventorySearchResults)
        {
            throw new NotImplementedException();
        }
    }
}
