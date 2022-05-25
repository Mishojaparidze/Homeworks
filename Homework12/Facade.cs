using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework12
{
    internal class Facade
    {

		SubSystemA subSystemA = new SubSystemA();
		SubSystemB subSystemB = new SubSystemB();
		public void OperationA()
		{
			subSystemA.OperationA();
			
		}
		public void OperationB()
		{
			subSystemB.OperationB();
		}
		class SubSystemA
		{
			public void OperationA()
			{
				Console.WriteLine("<header> My Header </header>");
				Console.WriteLine("<body> Video provides a powerful way to help you prove your point. When you click " +
					"Online Video, you can paste in the embed code for the video you want to add.<body>");
                Console.WriteLine("< footer > My Footer </ footer >");
			}
		}

		class SubSystemB
		{
			public void OperationB()
			{

                Console.WriteLine("I’m using Facade Pattern");
				Console.WriteLine("Video provides a powerful way to help you prove your point. When you click" +
                    "Online Video, you can paste in the embed code for the video you want to add." +
                    "You can also type a keyword to search online for the video that best fits your" +
                    "document.To make your document look professionally produced, Word provides");
                Console.WriteLine("Footer: Page 1");
			}
		}

	}
}
