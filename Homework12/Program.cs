using System;
using static Homework12.Concrete;

namespace Homework12
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Client client = new Client(new ArtDecoFactory());
            client.Run();
        }
    }
}