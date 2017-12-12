using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame.BaseClasses
{
    public abstract class ItemViewModelBase<TKey>
        where  TKey : IKey<TKey>
    {
        protected ItemViewModelBase(TKey obj)
        {
            DomainObject = obj;
        }
        public TKey DomainObject;
    }
}
