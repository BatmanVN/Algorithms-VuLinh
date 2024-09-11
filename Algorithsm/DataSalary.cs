using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithsm
{
    public class DataSalary
    {
        private float Money = 0;
        private float holdMoney = 0;
        public float calSalary(float salary, int n)
        {
            float bonus = 10f / 100f;
            for (int i = 0; i < n; i++)
            {
                if (i < n)
                   salary += salary * bonus;
            }
            return salary;
        }

        public float calSalaryRecursion(float salary, int n)
        {
            float bonus = 10f / 100f;
            if (n == 0)
                return salary;
            if (n > 0)
                salary += salary * bonus;
            return calSalaryRecursion(salary, n - 1);
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

        public float callMonthRecurison(float money, float rate , float month)
        {
            if (month == 0)
            {
                Money = money;
                holdMoney = money * (rate / 100f);
            }
            if (money >= Money * 2)
                return month;
            money += holdMoney;
            return callMonthRecurison(money, rate, month + 1);
        }
    }
}
