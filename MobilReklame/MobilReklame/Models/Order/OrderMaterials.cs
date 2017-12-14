using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class OrderMaterials : CatalogBase<Material, Material, int>
    {
        protected OrderMaterials(IFactory<Material, Material> factory) : base(factory)
        {
        }

        public override int NextKey()
        {
            throw new NotImplementedException();
        }
    }
}
