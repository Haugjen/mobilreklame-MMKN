using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MobilReklame.BaseClasses
{
    public abstract class CommandBase<TData, T, TKey> : ICommand
        where TKey : IKey<TKey>
        where TData : IKey<TKey>
        where T : TKey, new()
    {
        protected MasterDetailsViewModelBase<TData, T, TKey> _viewModel;
        protected CatalogBase<TData, T, TKey> _catalog;
        protected CommandBase(CatalogBase<TData, T, TKey> catalog, MasterDetailsViewModelBase<TData, T, TKey> viewModel)
        {
            _catalog = catalog;
            _viewModel = viewModel;
        }
        public abstract void Execute();
        public virtual bool CanExecute()
        {
            return true;
        }
        public bool CanExecute(object parameter)
        {
            return CanExecute();
        }
        public void Execute(object parameter)
        {
            Execute();
        }
        public event EventHandler CanExecuteChanged;
        public void RaiseCanExecuteChanged()
        {
            CanExecuteChanged?.Invoke(this, EventArgs.Empty);
        }
    }
}
