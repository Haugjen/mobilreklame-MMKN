using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace MobilReklame.Controllers.Commands.OrderCmd
{
    class OrderSaveCmd : ICommand

    {
        private OrderCatalog _catalog;

        public OrderSaveCmd(OrderCatalog catalog)
        {
            _catalog = catalog;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            _catalog.Save();
        }

        public event EventHandler CanExecuteChanged;
    }
}
