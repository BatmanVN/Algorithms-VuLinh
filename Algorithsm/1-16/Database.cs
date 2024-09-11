using Algorithsm._23_25;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Algorithsm
{
    public class Database : SigleTon<Database>
    {
        private List<Product> products = new List<Product>()
            {
                 new Product(KeyDic.nameCPU, 750, 10, 1),
                 new Product(KeyDic.nameRAM, 50, 2, 2),
                 new Product(KeyDic.nameHDD, 70, 1, 2),
                 new Product(KeyDic.nameMain, 400, 3, 1),
                 new Product(KeyDic.nameKeyboard, 30, 8, 4),
                 new Product(KeyDic.nameMouse, 25, 50, 4),
                 new Product(KeyDic.nameVGA, 60, 35, 3),
                 new Product(KeyDic.nameMonitor, 120, 28, 2),
                 new Product(KeyDic.nameCase, 120, 28, 5)
            };
        private List<Category> categories = new List<Category>()
        {
            new Category(1,KeyDic.nameComputer),
            new Category(2,KeyDic.nameMemory),
            new Category(3,KeyDic.nameCard),
            new Category(4,KeyDic.nameAcsesory)
        };
        public Dictionary<int, List<Product>> table = new Dictionary<int, List<Product>>()
        {
            {1, new List<Product>()},
            {2, new List<Product>()},
            {3, new List<Product>()},
            {4, new List<Product>()}
        };

        public List<Product> Products { get => products; }
        public List<Category> Categories { get => categories; }

        public Product FindProductName(string nameProduct , List<Product> pros)
        {
            Product product = new Product();
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i]._name == nameProduct)
                    product = Products[i];
            }
            return product;
        }
        public List<Product> FindProductByCategoryID(int categoryID, List<Product> pros)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i]._categoryId == categoryID)
                    pros.Add(Products[i]);
            }
            return pros;
        }

        public List<Product> FindProductByPrice(int price, List<Product> pros)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i]._price <= price)
                    pros.Add(Products[i]);
            }
            return pros;
        }
        public List<Product> SortByPrice(List<Product> pros)
        {
            Product prod;
            List<Product> prods = pros;
            for (int i = 0; i < prods.Count - 1; i++)
            {
                for (int j = i+1; j < prods.Count; j++)
                {
                    if (prods[i]._price > prods[j]._price)
                    {
                        prod = prods[j];
                        prods[j] = prods[i];
                        prods[i] = prod;
                    }
                }
            }
            return pros;
        }
        public List<Product> SortByName(List<Product> pros)
        {
            Product prod;
            List<Product> prods = pros;
            int holdPostion = 0;
            for (int i = 0; i < prods.Count; i++)
            {
                prod = prods[i];
                holdPostion = i;
                while (holdPostion > 0 && prods[holdPostion-1]._name.Length < prod._name.Length)
                {
                    prods[holdPostion] = prods[holdPostion-1];
                    holdPostion = holdPostion - 1;
                }
                prods[holdPostion] = prod;
            }
            return prods;
        }

        public List<Product> sortByCategoryName(List<Product> pros, List<Category> cate,int input)
        {
            mapProductByCategory(Products, Categories);
            Product prod;
            List<Product> prods = table[input];
            int holdPostion = 0;
            for (int i = 0; i < prods.Count; i++)
            {
                prod = prods[i];
                holdPostion = i;
                while (holdPostion > 0 && String.Compare(prods[holdPostion - 1]._name,prod._name) > 0)
                {
                    prods[holdPostion] = prods[holdPostion - 1];
                    holdPostion = holdPostion - 1;
                }
                prods[holdPostion] = prod;
            }
            return prods;
        }

        public List<Product> mapProductByCategory(List<Product> pros, List<Category> cate)
        {
            for (int j = 0; j < Products.Count; j++)
            {
                for (int i = 0; i < Categories.Count; i++)
                {
                    if (Products[j]._categoryId.Equals(Categories[i].id))
                    {
                        table[Categories[i].id].Add(Products[j]);
                    }
                }
            }
            return pros;
        }
        public Product minPrice(List<Product> pros)
        {
            Product product = new Product();
            product._price = Products[0]._price;
            for (int i = 0; i < Products.Count; i++)
            {
                if (product._price >= Products[i]._price)
                    product = Products[i];
            }
            return product;
        }
        public Product maxPrice(List<Product> pros)
        {
            Product product = new Product();
            product._price = Products[0]._price;
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i]._price >= product._price)
                    product = Products[i];
            }
            return product;
        }
    } 
}
