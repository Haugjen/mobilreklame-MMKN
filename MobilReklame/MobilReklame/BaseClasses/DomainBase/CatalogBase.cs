using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public abstract class CatalogBase<TData, T, TKey> : ICRUD<TData, TKey>
        where T : IKey<TKey>
    {
        private Dictionary<TKey, T> _data;
        private IFactory<T, TData> _factory;
        protected CatalogBase(IFactory<T, TData> factory)
        {
            _data = new Dictionary<TKey, T>();
            _factory = factory;
        }
        public List<T> All => _data.Values.ToList();

        public Dictionary<TKey, T> Data => _data;

        public void Create(TData data)
        {
            T obj = _factory.Convert(data);
            _data.Add(NextKey(), obj);  // make a keygen method -  remember to take file persistancy into account (using create with overload maybe for file persistancy)
        }
        public void Delete(TKey key)
        {
            _data.Remove(key);
        }
        public void Update(TData data)
        {
            T obj = _factory.Convert(data);
            _data.Remove(obj.Key);
            _data.Add(obj.Key, obj);
        }

        public abstract TKey NextKey();
        
    }
}
