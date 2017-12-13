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
        }


    }
}
