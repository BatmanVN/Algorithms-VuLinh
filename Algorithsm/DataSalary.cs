using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithsm
{
    public class DataSalary
    {
        public static float mone = 0;
        public float calSalary(float salary, int n)
        {
            float bonus = 10f / 100f;
            for (int i = 1; i < n; i++)
            {
                if (i < n)
                {
                    salary += salary * bonus;
                }
            }
            return salary;
        }

        public float calSalaryRecursion(float salary, int n)
        {
            float bonus = 10f / 100f;
            if (n == 1)
            {
                salary += salary * bonus;
                return salary;
            }
            return calSalaryRecursion(salary, n - 1) + calSalaryRecursion(salary, n - 1) * bonus;
        }

        public float callMonth(float money, float rate)
        {
            float month = 0;
            float moneyRate = 0;
            if (money > 0 && rate > 0)
            {
                moneyRate = money * (rate / 100f);
                month = money / moneyRate;
            }
            return month;
        }

        public float callMonthRecurison(float money, float rate)
        {
            //float month = 1;
            //float moneyRate = 0;
            //mone = money;

            return callMonthRecurison(money, rate);
        }

    }
}
