using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Algorithsm
{
    public class Product
    {
        public string _name;
        public int _price;
        public int _quality;
        public int _categoryId;
        public Product(string name, int price, int quality, int categoryId)
        {
            _name = name;
            _price = price;
            _quality = quality;
            _categoryId = categoryId;
        }
        public Product()
        {

        }
    }
}
