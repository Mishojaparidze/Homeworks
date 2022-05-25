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
<<<<<<< HEAD
<<<<<<< HEAD
				public abstract void Interact(AbstractFurniture furniture);
			}
=======
			public abstract void Interact(AbstractFurniture furniture);
		}
>>>>>>> 9b64764ce8c249ff3d5cf1a35ffdaac5a5ff845c
=======
			public abstract void Interact(AbstractFurniture furniture);
		}
>>>>>>> 9b64764ce8c249ff3d5cf1a35ffdaac5a5ff845c

			public abstract class AbstractFurniture {}

			public abstract class AbstractFactory
			{
				public abstract AbstractStyle CreateStyle();
				public abstract AbstractFurniture CreateFurniture();
			}
	}
}
