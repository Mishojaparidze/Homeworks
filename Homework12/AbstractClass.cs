using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12
{
    internal class AbstractClass
    {
			public abstract class AbstractStyle
			{
				public abstract void Interact(AbstractFurniture furniture);
			}

			public abstract class AbstractFurniture {}

			public abstract class AbstractFactory
			{
				public abstract AbstractStyle CreateStyle();
				public abstract AbstractFurniture CreateFurniture();
			}
	}
}
