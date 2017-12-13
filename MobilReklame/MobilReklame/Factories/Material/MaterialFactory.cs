using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class MaterialFactory : IFactory<Material, MaterialTDTO>
    {
        public Material Convert(MaterialTDTO obj)
        {
            throw new NotImplementedException();
        }
    }
}
