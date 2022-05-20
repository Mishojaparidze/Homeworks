using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12
{
    internal class AbstractClass
    {
		
		public abstract class AbstractFactory
		{
			public abstract AbstractChair CreateChair();
			public abstract AbstractSofa CreateSofa();
			public abstract AbstractTable CreateTable();
		}
		public abstract class AbstractChair
		{
			public abstract void Interact(AbstractChair Chair);
		}

		public abstract class AbstractSofa
		{
			public abstract void Interact(AbstractSofa Sofa);
		}

		public abstract class AbstractTable
		{
			public abstract void Interact(AbstractTable Table);
		}


		public abstract class AbstractStyle
		{
			public abstract void Interact(AbstractChair chair);
			public abstract void Interact(AbstractSofa sofa);
			public abstract void Interact(AbstractTable table);
		}











	}
}
