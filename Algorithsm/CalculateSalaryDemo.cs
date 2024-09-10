using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithsm
{
    public class CalculateSalaryDemo
    {
        static DataSalary dataSalary = new DataSalary();
        static void Main(string[] args)
        {
            CalSalary();
            CalsalaryRecursion();
            CallMonth();
            CallMonthRecursion();
            Console.ReadKey();
        }

        public static void CalSalary()
        {
            Console.Write("-Salary: ");
            float salary = float.Parse(Console.ReadLine());
            Console.Write("-Year: ");
            int year = int.Parse(Console.ReadLine());
            float salaryN = dataSalary.calSalary(salary, year);
            Console.WriteLine($"-Year: {year}  -Salary: {salaryN}");
        }

        public static void CalsalaryRecursion()
        {
            Console.Write("\n-Salary: ");
            float salary = float.Parse(Console.ReadLine());
            Console.Write("-Year: ");
            int year = int.Parse(Console.ReadLine());
            float salaryN = dataSalary.calSalaryRecursion(salary, year);
            Console.WriteLine($"-Year: {year}  -Salary: {salaryN}");
        }

        public static void CallMonth()
        {
            Console.Write("\n-Money: ");
            float money = int.Parse(Console.ReadLine());
            Console.Write("-Rate: ");
            float rate = int.Parse(Console.ReadLine());
            float month = dataSalary.callMonth(money, rate);
            Console.WriteLine($"-Money:{money} with -Rate:{rate} ");
            Console.WriteLine($"-Month to double Money: {(int)month}");
        }

        public static void CallMonthRecursion()
        {
            Console.Write("\n-Money: ");
            float money = int.Parse(Console.ReadLine());
            Console.Write("-Rate: ");
            float rate = int.Parse(Console.ReadLine());
            float month = 0; 
            month = dataSalary.callMonthRecurison(money, rate, month);
            Console.WriteLine($"-Money:{money} with -Rate:{rate} ");
            Console.WriteLine($"-Month to double Money: {month}");
        }
    }
}
