using System;

namespace Homework10
{
    internal class Program
    {

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
