using System;

namespace Homework10
{
    internal class Program
    {

        public interface FinanceOperations
        {
            int CalculateLoanPercent(int month);
            void CheckUserHistory();
        }

        public class Bank : FinanceOperations
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
                var y = random.Next(0,1001);
                
                if (y>500)
                {
                    Console.WriteLine(true);
                    int n = Convert.ToInt32(Console.ReadLine());
                    CalculateLoanPercent(n);
                }
            }

        }


        public class MicroFinance : FinanceOperations 
        {

            public int CalculateLoanPercent(int n)
            {
                var x = 10;
                var k = 4;
                Console.WriteLine(n * x / 100 + n*k+n);
                return n * x / 100 + n;
            }
            public void CheckUserHistory()
            {
                int n = Convert.ToInt32(Console.ReadLine());
                
                Console.WriteLine("true");
                CalculateLoanPercent(n);
            }

        }



        static void Main(string[] args)
        {
            #region Solution N1
            DerivedClass derivedClass = new DerivedClass();
            derivedClass.Read();
            derivedClass.Write();
            derivedClass.Edit();
            derivedClass.Delete();
            #endregion

            #region Solution N2 
            
            Bank bank = new Bank();
            bank.CheckUserHistory();

            MicroFinance microFinance = new MicroFinance();
            microFinance.CheckUserHistory();
            #endregion
        }
    }
}
