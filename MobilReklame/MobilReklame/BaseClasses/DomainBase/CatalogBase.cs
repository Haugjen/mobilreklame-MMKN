using MobilReklame.FilePersistancy;
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
        private FileSource<T, TKey> _dataSource;



        protected CatalogBase(IFactory<T, TData> factory)
        {
            _data = new Dictionary<TKey, T>();
            _factory = factory;
            _dataSource = new FileSource<T, TKey>(new FileStringPersistence(), new JSONConverter<T>());

        }
        public List<T> All => _data.Values.ToList();

        public Dictionary<TKey, T> Data => _data;

        public void Create(TData data)
        {
            T obj = _factory.Convert(data);
            TKey newKey = NextKey();
            obj.Key = newKey;
            _data.Add(newKey, obj);
            Save();
        }
        public void Delete(TKey key)
        {
            _data.Remove(key);
            Save();

        }
        public void Update(TData data)
        {
            T obj = _factory.Convert(data);
            _data.Remove(obj.Key);
            _data.Add(obj.Key, obj);
            Save();
        }

        public async void Save()
        {
            await _dataSource.Save(Data);
        }

        public async void Load()
        {
            _data = await _dataSource.Load();
        }

        public abstract TKey NextKey();
        
    }
}
