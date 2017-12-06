using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MobilReklame.BaseClasses
{
public class DeleteCommandBase<TDomainClass, TViewModel> : CommandBase<TDomainClass>
        where TViewModel : MasterDetailsViewModelBase<TDomainClass>
        where TDomainClass :  DomainBase, new()
    {
        private CatalogBase<TDomainClass> _catalog;
        private TViewModel _viewModel;

        public DeleteCommandBase(CatalogBase<TDomainClass> catalog, TViewModel viewModel)
        : base(viewModel)
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
            // Delete from catalog
            _catalog.Delete(_viewModel.ItemViewModelSelected.DomainObject.Key);

            // Set selection to null
            _viewModel.ItemViewModelSelected = null;

            // Refresh the item list
            _viewModel.RefreshItemViewModelCollection();
        }
    }
}
