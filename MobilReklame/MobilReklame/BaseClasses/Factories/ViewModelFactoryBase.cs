using System.Collections.Generic;
using System.Linq;
    
    namespace MobilReklame
    {
        public abstract class ViewModelFactoryBase<TData, T, TKey>
        where TKey : IKey<TKey>
        where T : TKey
        {
            public abstract ItemViewModelBase<T,TKey> CreateItemViewModel(T obj);
            public List<ItemViewModelBase<T, TKey>> GetItemViewModelCollection(CatalogBase<TData, T, TKey> catalog)
            {
                List<ItemViewModelBase<T, TKey>> items = new List<ItemViewModelBase<T, TKey>>();

                foreach (T obj in catalog.All)
                {
                    items.Add(CreateItemViewModel(obj));
                }
                return items;
            }
        }
    }
