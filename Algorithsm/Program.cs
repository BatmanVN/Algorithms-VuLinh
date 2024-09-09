using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Algorithsm
{
    public class Program
    {

        static void Main(string[] args)
        {
            FindProductByName();
            FindProductByCateID();
            FindProductByPrice();
            SortByPrice();
            SortByNameLenght();
            MapProductByCate();
            MinPrice();
            MaxPrice();
            Console.ReadKey();
        }

        private static void MinPrice()
        {
            Console.WriteLine("\n-Min Price: " );
            Product product = Database.Instance.minPrice(Database.Instance.Products);
            PrintATable(product);
        }
        private static void MaxPrice()
        {
            Console.WriteLine("\n-Max Price: ");
            Product product = Database.Instance.maxPrice(Database.Instance.Products);
            //product = Database.Instance.maxPrice(Database.Instance.Products);
            PrintATable(product);
        }
        public static void FindProductByName()
        {
            Console.Write("-Input Name: ");
            string nameProduct = Console.ReadLine().ToUpper();
            Product product = new Product();
            product = Database.Instance.FindProductName(nameProduct, Database.Instance.Products);
            PrintATable(product);
        }
        public static void FindProductByCateID()
        {
            Console.Write("\n-Input CateID: ");
            int cateID = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();
            products = Database.Instance.FindProductByCategoryID(cateID, products);
            PrintTable(products);
        }

        public static void FindProductByPrice()
        {
            Console.Write("\n-Input Price: ");
            int cateID = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();
            products = Database.Instance.FindProductByPrice(cateID, products);
            PrintTable(products);
        }

        public static void SortByPrice()
        {
            Console.WriteLine("\n-Sort Price: ");
            List<Product> products = new List<Product>();
            products = Database.Instance.SortByPrice(products);
            PrintTable(products);
        }
        public static void SortByNameLenght()
        {
            Console.WriteLine("\n-Sort Name Lenght: ");
            List<Product> products = new List<Product>();
            products = Database.Instance.SortByName(products);
            PrintTable(products);
        }
        public static void MapProductByCate()
        {
            Console.Write("\n-Product & Category: ");
            int input = int.Parse(Console.ReadLine());
            List<Product> products = new List<Product>();
            products = Database.Instance.table[input];
            Database.Instance.mapProductByCategory(products,Database.Instance.Categories);
            Console.WriteLine($"-Category Name: {Database.Instance.Categories[input - 1].name}  ID: {Database.Instance.Categories[input - 1].id}");
            PrintTable(products);
        }
        public static void PrintTable(List<Product> pro)
        {
            for (int i = 0; i < pro.Count; i++)
            {
                Console.WriteLine($"Name: {pro[i]._name}  Price:{pro[i]._price}  Quality:{pro[i]._quality}  CategoryID:{pro[i]._categoryId}");
            }
        }
        //public static void PrintTableWithCate(List<Product> pro, List<Category> cate)
        //{
        //    for (int i = 0; i < pro.Count; i++)
        //    {
        //        Console.WriteLine($"Name: {cate[i].name}  ID:{cate[i].id}");
        //        Console.WriteLine($"Name: {pro[i]._name}  Price:{pro[i]._price}  Quality:{pro[i]._quality}  CategoryID:{pro[i]._categoryId}");
        //    }
        //}
        public static void PrintATable(Product product)
        {
            Console.WriteLine($"Name: {product._name}  Price:{product._price}  Quality:{product._quality}  CategoryID:{product._categoryId}");
        }
    }
}
