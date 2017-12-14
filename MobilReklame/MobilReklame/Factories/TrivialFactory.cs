using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame.Factories
{
    public class TrivialFactory<T> : IFactory<T, T>
    {
        public T Convert(T obj)
        {
            return obj;
        }
    }
}
