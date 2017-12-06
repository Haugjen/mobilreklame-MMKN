using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MobilReklame.BaseClasses
{
         /// <summary>
    /// Base class for handlers. Most handlers will need access to
    /// view model and domain model, which is provided by this class.
    /// </summary>
    /// <typeparam name="TDomainClass"></typeparam>
    public abstract class CommandBase<TDomainClass> : ICommand
        where TDomainClass : DomainBase, new()
    {
        protected MasterDetailsViewModelBase<TDomainClass> MasterDetailsViewModel;
        protected DomainBase DomainModel;
   
        //Do we even need this data in the constructor ??????!!!
        protected CommandBase(MasterDetailsViewModelBase<TDomainClass> masterDetailsViewModel)
        {
            MasterDetailsViewModel = masterDetailsViewModel; 
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
