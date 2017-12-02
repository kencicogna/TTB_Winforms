using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProductManager.Views;
using ProductManager.Presenters;

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

            // User Controls / Views / Helper Objects
            var ucInventorySearchResults = new UCInventorySearchResults();
            var ucInventoryProductEditor = new UCInventoryProductEditor();
            var inventoryView = new UCInventoryView(ucInventorySearchResults, ucInventoryProductEditor);

            // Presenters
            inventoryView.Tag = new InventoryPresenter(inventoryView);

            // Main Form
            var mainForm = new MainForm(inventoryView);
            mainForm.Tag = new MainFormPresenter(mainForm);

            // Start Application
            Application.Run(mainForm);
        }
    }
}
