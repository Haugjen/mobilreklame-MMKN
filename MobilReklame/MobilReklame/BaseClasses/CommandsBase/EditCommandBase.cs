using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame.BaseClasses
{
    public class EditCommandBase<TData, T, TKey> : CommandBase<TData, T, TKey>
        where TKey : IKey<TKey>
        where T : TKey, new()
    {
        private CatalogBase<TData, T, TKey> _catalog;
        protected MasterDetailsViewModelBase<TData, T, TKey> _viewModel;
        public EditCommandBase(CatalogBase<TData, T, TKey> catalog, MasterDetailsViewModelBase<TData, T, TKey> viewModel)
        {
            _catalog = catalog;
            _viewModel = viewModel;
        }
        public override bool CanExecute()
        {
            return _viewModel.ItemViewModelSelected != null;
        }
        public override void Execute()
        {
            // Update/edit
            _catalog.Update();

            // Set selection to null
            _viewModel.ItemViewModelSelected = null;

            // Refresh the item list
            _viewModel.RefreshItemViewModelCollection();
        }

    }
}
