using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{ 
    public abstract class ItemViewModelBase<T, TKey>
        where  T : IKey<TKey>
    {
        protected ItemViewModelBase(T obj)
        {
            DomainObject = obj;
        }
        public T DomainObject;
    }
}
