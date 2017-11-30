using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProductManager.Views;
using ProductManager.Models;
using ProductManager.Events;

namespace ProductManager.Presenters
{
    class InventoryPresenter
    {
        private IInventorySearchBar inventorySerachBarView;
        private IInventoryProductEditor inventoryProductEditorView;
        private IInventorySearchResults inventorySearchResultsView;

        public InventoryPresenter(IInventorySearchBar inventorySerachBarView, 
                                  IInventoryProductEditor inventoryProductEditorView,
                                  IInventorySearchResults inventorySearchResultsView)
        {
            this.inventorySerachBarView = inventorySerachBarView;
            this.inventoryProductEditorView = inventoryProductEditorView;
            this.inventorySearchResultsView = inventorySearchResultsView;

            EventAggregator.Instance.Subscribe<InventoryShowSearchResultView>(OnBtnShowSearchResultsView_Click);
            EventAggregator.Instance.Subscribe<InventoryShowProductEditorView>(OnBtnShowProductView_Click);
        }

        private void OnBtnShowSearchResultsView_Click(InventoryShowSearchResultView obj)
        {
            inventorySearchResultsView.ShowView();
            inventoryProductEditorView.HideView();
        }

        private void OnBtnShowProductView_Click(InventoryShowProductEditorView obj)
        {
            inventoryProductEditorView.ShowView();
            inventorySearchResultsView.HideView();
        }

        public void OnSearchTextChanged(InventoryShowSearchResultView inventorySearch)
        {
            // use is.SearchString to query db and return result to the view
  
        }
    }
}
