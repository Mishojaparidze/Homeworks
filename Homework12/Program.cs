using System;
using static Homework12.Concrete;
using static Homework12.Movie;

namespace Homework12
{
    internal class Program
    {

        static void Main(string[] args)
        {
            #region SolutionAbstractFactory
            Console.WriteLine("SolutionAbstractFactory");
            Client client1 = new Client(new ArtDecoFactory());
            client1.Run();
            Client client2 = new Client(new VictorianFactory());
            client2.Run();
            Client client3 = new Client(new ModernFactory());
            client3.Run();
            #endregion

            #region SolutionProxy
            Console.WriteLine("SolutionProxy");

            RealMovie movie1 = new Stuntman();
            movie1.Request();

            RealActor actor = new RealActor();
            actor.Request();
            #endregion

            #region SolutionFacade
            Console.WriteLine("SolutionFacade");
            Facade facade = new Facade();
            Console.WriteLine("HTML");
            facade.OperationA();
            Console.WriteLine("PDF");
            facade.OperationB();
            #endregion
        }
    }
}