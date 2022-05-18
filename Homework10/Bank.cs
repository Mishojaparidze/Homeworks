using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{

    public interface FinanceOperations
    {
        int CalculateLoanPercent(int month);
        void CheckUserHistory();
    }

    internal class Bank : FinanceOperations
    {
        public int CalculateLoanPercent(int n)
        {
                var x = 5;
                Console.WriteLine(n * x / 100 + n);
                return n * x / 100 + n;
        }
        public void CheckUserHistory()
        {
            var random = new Random();
            var y = random.Next(0, 1001);

            if (y > 500)
            {
                Console.WriteLine(true);
                int n = Convert.ToInt32(Console.ReadLine());
                CalculateLoanPercent(n);
            }
        }
    }
}
