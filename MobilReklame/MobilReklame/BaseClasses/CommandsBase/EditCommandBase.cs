using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class EditCommandBase<TData, T, TKey> : CommandBase<TData, T, TKey>
        where TKey : IKey<TKey>
        where TData : IKey<TKey>
        where T : TKey, new()
    {
        public EditCommandBase(CatalogBase<TData, T, TKey> catalog, MasterDetailsViewModelBase<TData, T, TKey> viewModel)
        :base(catalog, viewModel){}
        
        public override bool CanExecute()
        {
            return _viewModel.ItemViewModelSelected != null;
        }
        public override void Execute()
        {
            _catalog.Update(_viewModel.DataPackage);
            _viewModel.ItemViewModelSelected = null;
            _viewModel.RefreshItemViewModelCollection();
        }

    }
}
