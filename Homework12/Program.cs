using System;
using static Homework12.Concrete;

namespace Homework12
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Client client1 = new Client(new ArtDecoFactory());
            client1.Run();
            Client client2 = new Client(new VictorianFactory());
            client2.Run();
            Client client3 = new Client(new ModernFactory());
            client3.Run();
        }
    }
}