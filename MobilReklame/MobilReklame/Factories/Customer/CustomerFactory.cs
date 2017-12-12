using System.Collections.Generic;
using System.Linq;

namespace MobilReklame
{
    public class CustomerFactory : IFactory<T, TData>
    {
        public CustomerFactory(TData)
        {
        }

        public T Convert(TData obj)
        {
            throw new System.NotImplementedException();
        }
    }

}