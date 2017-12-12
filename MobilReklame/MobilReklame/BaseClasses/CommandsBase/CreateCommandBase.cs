using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame.BaseClasses
{
public class CreateCommandBase<TData, T, TKey> : CommandBase<TData, T, TKey>
        where TKey : IKey<TKey>
        where TData : IKey<TKey>
        where T : TKey, new()
    {
        public CreateCommandBase(CatalogBase<TData, T, TKey> catalog, MasterDetailsViewModelBase<TData, T, TKey> viewModel)
        :base(catalog, viewModel){}
        public override bool CanExecute()
        {
            return true;
        }
        public override void Execute()
        {
            _catalog.Create(_viewModel.DataPackage);
        }
    }
}
