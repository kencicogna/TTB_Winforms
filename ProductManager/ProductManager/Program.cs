using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManager.Views;
using ProductManager.Views.Inventory;
using ProductManager.Presenters;
using ProductManager.Presenters.Inventory;

namespace ProductManager
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //
            // Create Dependancies
            //

            // User Controls / Presenters
            var ucInventorySearchBar = new UCInventorySearchBar();
            ucInventorySearchBar.Tag = new InventorySearchBarPresenter(ucInventorySearchBar);

            var ucInventorySearchResults = new UCInventorySearchResults();
            ucInventorySearchResults.Tag = new InventorySearchResultsPresenter(ucInventorySearchResults);

            var ucInventoryProductEditor = new UCInventoryProductEditor();
            ucInventoryProductEditor.Tag = new InventoryProductEditorPresenter(ucInventoryProductEditor);

            var inventoryView = new UCInventoryView(ucInventorySearchBar, ucInventorySearchResults, ucInventoryProductEditor);
            inventoryView.Tag = new InventoryPresenter(inventoryView);

            // Main Form
            var mainForm = new MainForm(inventoryView);
            mainForm.Tag = new MainFormPresenter(mainForm);

            // Start Application
            Application.Run(mainForm);
        }
    }
}
