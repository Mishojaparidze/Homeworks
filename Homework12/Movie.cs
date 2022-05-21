using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12
{
    internal class Movie
    {

        public abstract class RealMovie
        {
            public abstract void Request();
        }

        public class RealActor : RealMovie
        {
            public override void Request()
            {
                Console.WriteLine("Real actor plays in movie");
            }
        }
        public class Stuntman : RealMovie
        {

            RealActor realActor;
            public override void Request()
            {
                Random random = new Random();
                var x=random.Next(0,101);
                if (x>20) // if x <=20 it throws an error :/
                    realActor = new RealActor();
               realActor.Request();

                Console.WriteLine("now StuntMan! You play in the movie");
            }
        }

    }
}
