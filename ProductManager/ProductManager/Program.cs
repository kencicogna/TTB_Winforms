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
            // Create dependancies
            //

            // User Controls / Views / Objects

            // Presenters
            
            // Main Form
            var mainForm = new MainForm();
            mainForm.Tag = new MainFormPresenter(mainForm);

            // Start Application
            Application.Run(mainForm);
        }
    }
}
