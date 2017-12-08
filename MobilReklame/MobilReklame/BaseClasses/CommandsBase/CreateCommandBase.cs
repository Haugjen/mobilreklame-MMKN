using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame.BaseClasses
{
public class CreateCommandBase<TData, T, TKey> : CommandBase<TData, T, TKey>
        where TKey : IKey<TKey>
        where T : TKey, new()
    {
        private CatalogBase<TData, T, TKey> _catalog;
        private TData _TDTO;
        public CreateCommandBase(CatalogBase<TData, T, TKey> catalog, TData TDTO)
        {
            _catalog = catalog;
            _TDTO = TDTO;
        }
        public override bool CanExecute()
        {
            //Maybe add a condition later...
            return true;
        }
        public override void Execute()
        {
            // Add to catalog
            _catalog.Create(_TDTO);
        }
    }
}
