using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame.BaseClasses
{
 /// <summary>
    /// A domain class must inherit from this class,
    /// and implement the Key property
    /// </summary>
    public abstract class DomainBase
    {
        public abstract int Key { get; set; }
    }
}
