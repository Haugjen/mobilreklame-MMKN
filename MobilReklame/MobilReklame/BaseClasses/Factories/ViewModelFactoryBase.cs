using System.Collections.Generic;
using System.Linq;
    
    namespace MobilReklame.BaseClasses
    {
        public abstract class ViewModelFactoryBase<TData, T, TKey>
        where TKey : IKey<TKey>
        where T : TKey
        {
            public abstract ItemViewModelBase<TKey> CreateItemViewModel(T obj);
            public List<ItemViewModelBase<TKey>> GetItemViewModelCollection(CatalogBase<TData, T, TKey> catalog)
            {
                List<ItemViewModelBase<TKey>> items = new List<ItemViewModelBase<TKey>>();

                foreach (T obj in catalog.All)
                {
                    items.Add(CreateItemViewModel(obj));
                }
                return items;
            }
        }
    }
