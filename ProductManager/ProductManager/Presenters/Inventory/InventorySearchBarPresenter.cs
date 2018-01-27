using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManager.Events;
using ProductManager.Models;
using ProductManager.Views.Inventory;
using System.Data.SqlClient;

namespace ProductManager.Presenters.Inventory
{
    class InventorySearchBarPresenter
    {
        private UCInventorySearchBar inventorySearchBar;

        public InventorySearchBarPresenter(UCInventorySearchBar isb)
        {
            inventorySearchBar = isb;
            EventAggregator.Instance.Subscribe<InventoryProductSearch>(OnSetSearchBarFocus);
        }

        private void OnSetSearchBarFocus(InventoryProductSearch obj)
        {
            EventAggregator.Instance.Publish(new SpeechBubble { Text = "Enter SKU, UPC, or any part of Title to search for products" });
            inventorySearchBar.SetSearchBoxFocus();
        }
    }
}
