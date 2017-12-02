using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManager.Views;
using ProductManager.Events;

namespace ProductManager.Presenters
{
    class MainFormPresenter
    {
        private MainForm mainForm;

        public MainFormPresenter(MainForm mf)
        {
            mainForm = mf;
            EventAggregator.Instance.Subscribe<InventoryProductSearch>(OnSearchTextChanged_SetStatus);
        }

        private void OnSearchTextChanged_SetStatus(InventoryProductSearch obj)
        {
            mainForm.SetStatus("Searching for products...");
        }
    }
}
