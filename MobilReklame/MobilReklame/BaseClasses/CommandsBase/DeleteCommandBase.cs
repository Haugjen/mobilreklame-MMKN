using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MobilReklame
{
public class DeleteCommandBase<TData, T, TKey> : CommandBase<TData, T, TKey>
        // where TKey : IKey<TKey>
        where TData : IKey<TKey>
        where T : IKey<TKey>, new()
    {
        public DeleteCommandBase(CatalogBase<TData, T, TKey> catalog, MasterDetailsViewModelBase<TData, T, TKey> viewModel)
        :base(catalog, viewModel){}
        public override bool CanExecute()
        {
            return _viewModel.ItemViewModelSelected != null;
        }
        public override void Execute()
        {
            _catalog.Delete(_viewModel.ItemViewModelSelected.DomainObject.Key);
            _viewModel.ItemViewModelSelected = null;
            _viewModel.RefreshItemViewModelCollection();
        }
    }
}
