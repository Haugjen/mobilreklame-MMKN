using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobilReklame
{
    public class Material : IKey<int>
    {
        private string _name;
        private int _quantity;
        private string _size;
        private int _prize;
        private int _materialNumber = 0;

        public Material(string name, int quantity, string size, int prize)
        {
            _name = name;
            _quantity = quantity;
            _size = size;
            _prize = prize;
        }

        public string Name { get => _name; set => _name = value; }
        public int Quantity { get => _quantity; set => _quantity = value; }
        public string Size { get => _size; set => _size = value; }
        public int Prize { get => _prize; set => _prize = value; }
        public int Key { get => _materialNumber; set => value = _materialNumber; }
    }
}
