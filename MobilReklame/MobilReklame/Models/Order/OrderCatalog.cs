using MobilReklame.FilePersistancy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class OrderCatalog : CatalogBase<Order, Order, int>
    {
        private static OrderCatalog _orderCatalog;
        private FileSource<Order, int> _dataSource;

        private OrderCatalog(IFactory<Order, Order> factory) : base(factory)
        {
            _dataSource = new FileSource<Order, int>(new FileStringPersistence(), new JSONConverter<Order>());
        }

        public static OrderCatalog Instance
        {
            get
            {
                if (_orderCatalog != null)
                {
                    return _orderCatalog;
                }
                _orderCatalog = new OrderCatalog(new Factories.TrivialFactory<Order>());
                return _orderCatalog;
            }
        }
     
        public override int NextKey()
        {
            int nextKey = (int)Data.Keys.Max() + 1;
            return nextKey;
        }

        public async void Save()
        {
            await _dataSource.Save(Data);
        }
    }
}
