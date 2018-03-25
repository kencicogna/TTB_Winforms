using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManager.Views.Inventory;
using ProductManager.Models;
using ProductManager.Events;

namespace ProductManager.Presenters.Inventory
{
    class InventoryPresenter
    {
        private readonly IInventoryView inventoryView;

        public InventoryPresenter(IInventoryView iv)
        {
            inventoryView = iv;

            // Adds Product Editor control to Inventory view
            EventAggregator.Instance.Subscribe<InventoryShowProductEditorView>(OnBtnShowProductView_Click);
            EventAggregator.Instance.Subscribe<InventoryProductDetails>(OnDisplayProductDetails);

            // Adds Search Results control to Inventory view
            EventAggregator.Instance.Subscribe<InventoryShowSearchResultView>(OnBtnShowSearchResultsView_Click);
            //EventAggregator.Instance.Subscribe<InventoryProductSearch>(OnBtnShowSearchResultsView_Click);            
        }

        private void OnBtnShowSearchResultsView_Click(InventoryShowSearchResultView obj)
        {
            inventoryView.ShowSearchResultsView();
        }

        private void OnBtnShowSearchResultsView_Click(InventoryProductSearch obj)
        {
            inventoryView.ShowSearchResultsView();
        }

        private void OnBtnShowProductView_Click(InventoryShowProductEditorView obj)
        {
            inventoryView.ShowProductEditorView();
        }

        private void OnDisplayProductDetails(InventoryProductDetails obj)
        {
            inventoryView.ShowProductEditorView();
        }

    }
}
