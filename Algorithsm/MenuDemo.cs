using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithsm
{
    public class MenuDemo
    {
        static MenuData menuData = new MenuData();
        static void Main(string[] args)
        {
            PrintMenu();
            Console.ReadKey();
        }
        public static void PrintMenu()
        {

        }

        public static void printTable(List<Menu> list)
        {
            foreach (Menu menu in list)
            {
                Console.WriteLine($"{menu.title}");
            }
        }
    }
}
