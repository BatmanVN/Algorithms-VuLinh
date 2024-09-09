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

        public List<Product> Products { get => products; }
        public List<Category> Categories { get => categories; }

        public Product FindProductName(string nameProduct , List<Product> pros)
        {
            Product product = new Product();
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i]._name == nameProduct)
                {
                    product = Products[i];
                }
            }
            return product;
        }
        public List<Product> FindProductByCategoryID(int categoryID, List<Product> pros)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i]._categoryId == categoryID)
                {
                    pros.Add(Products[i]);
                }
            }
            return pros;
        }

        public List<Product> FindProductByPrice(int price, List<Product> pros)
        {
            for (int i = 0; i < Products.Count; i++)
            {
                if (Products[i]._price <= price)
                {
                    pros.Add(Products[i]);
                }
            }
            return pros;
        }
        public List<Product> SortByPrice(List<Product> pros)
        {
            Product prod;
            for (int i = 0; i < Products.Count - 1; i++)
            {
                for (int j = i+1; j < Products.Count; j++)
                {
                    if (Products[i]._price > Products[j]._price)
                    {
                        prod = Products[j];
                        Products[j] = Products[i];
                        Products[i] = prod;
                    }
                }
            }
            pros = Products;
            return pros;
        }
        public List<Product> SortByName(List<Product> pros)
        {
            Product prod;
            for (int i = 0; i < Products.Count - 1; i++)
            {
                for (int j = i + 1; j < Products.Count; j++)
                {
                    if (Products[i]._name.Length < Products[j]._name.Length)
                    {
                        prod = Products[j];
                        Products[j] = Products[i];
                        Products[i] = prod;
                    }
                }
            }
            pros = Products;
            return pros;
        }

        public List<Product> sortByCategoryName(List<Product> pros, List<Category> cate)
        {


            return pros;
        }

        public List<Product> mapProductByCategory(List<Product> pros, List<Category> cate)
        {
            int ID = 0;
            for (int i = 0; i < Categories.Count; i++)
            {
                ID = Categories[i].id;
            }
            for (int j = 0; j < Products.Count; j++)
            {
                if (Products[j]._categoryId == ID)
                {
                    pros.Add(Products[j]);
                }
            }
            return pros;
        }
        public Product minPrice(List<Product> pros)
        {
            Product product = new Product();
            product._price = Products[0]._price;
            for (int i = 1; i < Products.Count; i++)
            {
                if (product._price > Products[i]._price)
                {
                    product = Products[i];
                }
            }
            return product;
        }
        public Product maxPrice(List<Product> pros)
        {
            Product product = new Product();
            product._price = Products[0]._price;
            for (int i = 1; i < Products.Count; i++)
            {
                if (Products[i]._price > product._price)
                {
                    product = Products[i];
                }
                else
                    product = Products[0];
            }
            return product;
        }
    } 
}
