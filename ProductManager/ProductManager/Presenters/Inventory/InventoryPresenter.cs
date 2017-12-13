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

            // keep
            EventAggregator.Instance.Subscribe<InventoryShowSearchResultView>(OnBtnShowSearchResultsView_Click);
            EventAggregator.Instance.Subscribe<InventoryShowProductEditorView>(OnBtnShowProductView_Click);

            EventAggregator.Instance.Subscribe<InventoryProductDetails>(OnDisplayProductDetails);

        }

        //private void DisplaySearchResults(InventorySearchResult obj)
        //{
        //    inventoryView.DisplaySearchResults
        //}

        private void DisplaySearchResults(InventorySearchResults inventorySearchResults)
        {
            inventoryView.DisplayResultsInProductEditor(inventorySearchResults);
        }

        private void OnBtnShowSearchResultsView_Click(InventoryShowSearchResultView obj)
        {
            inventoryView.ShowSearchResultsView();
        }

        private void OnBtnShowProductView_Click(InventoryShowProductEditorView obj)
        {
            inventoryView.ShowProductEditorView();
        }

        // is this being called?
        private void OnDisplayProductDetails(InventoryProductDetails obj)
        {
            inventoryView.ShowProductEditorView();
        }

    }
}
