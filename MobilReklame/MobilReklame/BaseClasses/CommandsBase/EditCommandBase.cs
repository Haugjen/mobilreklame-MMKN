using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame.BaseClasses
{
    public class EditCommandBase<TDomainClass, TViewModel> : CommandBase<TDomainClass>
        where TViewModel : MasterDetailsViewModelBase<TDomainClass>
        where TDomainClass :  DomainBase, new()
    {
        private CatalogBase<TDomainClass> _catalog;
        private TViewModel _viewModel;
        public EditCommandBase(CatalogBase<TDomainClass> catalog, TViewModel viewModel)
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
            // Edit object information
            

            // Set selection to null
            _viewModel.ItemViewModelSelected = null;

            // Refresh the item list
            _viewModel.RefreshItemViewModelCollection();
        }

    }
}
