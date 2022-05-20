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
		public class ArtDecoStyle : AbstractStyle
		{
			public override void Interact(AbstractChair chair)
			{
				Console.WriteLine(this + " interacts with " + chair);
			}
            public override void Interact(AbstractSofa sofa)
            {
				Console.WriteLine(this + " interacts with " + sofa);
			}
			public override void Interact(AbstractTable table)
			{
				Console.WriteLine(this + " interacts with " + table);
			}

		}

		public class VictorianStyle : AbstractStyle
		{
			public override void Interact(AbstractChair chair)
			{
				Console.WriteLine(this + " interacts with " + chair);
			}
			public override void Interact(AbstractSofa sofa)
			{
				Console.WriteLine(this + " interacts with " + sofa);
			}
			public override void Interact(AbstractTable table)
			{
				Console.WriteLine(this + " interacts with " + table);
			}

		}

		public class ModernStyle : AbstractStyle
		{
			public override void Interact(AbstractChair chair)
			{
				Console.WriteLine(this + " interacts with " + chair);
			}
			public override void Interact(AbstractSofa sofa)
			{
				Console.WriteLine(this + " interacts with " + sofa);
			}
			public override void Interact(AbstractTable table)
			{
				Console.WriteLine(this + " interacts with " + table);
			}

		}

		class ArtDecoFactory : AbstractFactory
		{
			public override AbstractChair CreateChair()
			{
                return new ArtDecoStyle();
			}
			public override AbstractTable CreateTable()
			{
				return new ArtDecoStyle();
			}

			public override AbstractSofa CreateSofa()
			{
				return new ArtDecoStyle();
			}
		}


		public class Client
		{
			private AbstractTable table;
			private AbstractChair chair;
			private AbstractSofa sofa;

			public Client(AbstractFactory factory)
			{
				chair = factory.CreateChair();
				sofa = factory.CreateSofa();
				table = factory.CreateTable();
			}
			public void Run()
			{
				chair.Interact(chair);
				table.Interact(table);
				sofa.Interact(sofa);
			}
		}
	}
}
