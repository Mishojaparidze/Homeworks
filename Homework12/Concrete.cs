using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Homework12.AbstractClass;

namespace Homework12
{
    internal class Concrete
    {
        class ArtDecoStyle : AbstractStyle
        {
            public override void Interact(AbstractFurniture style)
            {
                Console.WriteLine(this + "interacts with " + style);
            }
        }
        class ArtDecoFurniture : AbstractFurniture { }
        class VictorianStyle : AbstractStyle
        {
            public override void Interact(AbstractFurniture style)
            {
                Console.WriteLine(this + "interacts with " + style);
            }
        }
        class VictorianFurniture : AbstractFurniture { }
        class ModernStyle : AbstractStyle
        {
            public override void Interact(AbstractFurniture style)
            {
                Console.WriteLine(this + "interacts with " + style);
            }
        }
        class ModernFurniture : AbstractFurniture { }
        public class ArtDecoFactory : AbstractFactory
        {
            public override AbstractFurniture CreateFurniture()
            {
                return new ArtDecoFurniture();
            }
            public override AbstractStyle CreateStyle()
            {
                return new ArtDecoStyle();
            }
        }
        public class VictorianFactory : AbstractFactory
        {
            public override AbstractFurniture CreateFurniture()
            {
                return new VictorianFurniture();
            }
            public override AbstractStyle CreateStyle()
            {
                return new VictorianStyle();
            }
        }
        public class ModernFactory : AbstractFactory
        {
            public override AbstractFurniture CreateFurniture()
            {
                return new ModernFurniture();
            }
            public override AbstractStyle CreateStyle()
            {
                return new ModernStyle();
            }
        }


        public class Client 
        {
            private AbstractStyle _style;
            private AbstractFurniture _furniture;
            public Client(AbstractFactory factory)
            {
                _style = factory.CreateStyle();
                _furniture = factory.CreateFurniture();
            }

            public void Run()
            {
                _style.Interact(_furniture);
            }


        }




    }
}
