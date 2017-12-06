using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame.BaseClasses
{
public class CreateCommandBase<TDomainClass, TViewModel, TViewModelObj> : CommandBase<TDomainClass>
        where TViewModel : MasterDetailsViewModelBase<TDomainClass>
        where TDomainClass :  DomainBase, new()
    {
        private CatalogBase<TDomainClass> _catalog;
        private TViewModel _viewModel;
        private TDomainClass _domainObj;

        private TViewModelObj _viewModelObj;

        public CreateCommandBase(CatalogBase<TDomainClass> catalog, TViewModel viewModel ,TViewModelObj viewModelObject)
        : base(viewModel)
        {
            _catalog = catalog;
            _viewModelObj = viewModelObject;
            
        }

        public override bool CanExecute()
        {
            //Temp
            return true;
        }

        public override void Execute()
        {
            // Add to catalog
            _catalog.Add(_viewModelObj);

            // Refresh the item list
            _viewModel.RefreshItemViewModelCollection();
        }
    }
}
