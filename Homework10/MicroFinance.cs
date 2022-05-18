using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    internal class MicroFinance : FinanceOperations
    {
       public int CalculateLoanPercent(int n)
       {
                var x = 10;
                var k = 4;
                Console.WriteLine(n * x / 100 + n * k + n);
                return n * x / 100 + n;
       }
        public void CheckUserHistory()
        {
                int n = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("true");
                CalculateLoanPercent(n);
        }


    }
}
