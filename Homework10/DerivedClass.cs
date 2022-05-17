using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    internal class DerivedClass : FileWorker
    {
        string maxSizeType = "txt";
        string MaximumSize="128";
        public override string MaximumSizeType { 
            
            get { return maxSizeType; }
            set { maxSizeType = value; }
        }
       
        public override void Read()
        {
            MaximumSize = "128";
           
            Console.WriteLine($"I can Write TXT {MaximumSizeType} with max storage {MaximumSize}");
        }
        public override void Write()
        {
            MaximumSize = "128";
            
            Console.WriteLine($"I can read from {MaximumSizeType} file with max storage {MaximumSize}"); 
        }
        public override void Edit()
        {
            MaximumSize = "128";
            
            Console.WriteLine($"I can edit from {MaximumSizeType} file with max storage {MaximumSize}");
        }
        public override void Delete()
        {
            MaximumSize = "128";
          
            Console.WriteLine($"I can delete from {MaximumSizeType} file with max storage {MaximumSize}");
        }


    }
}
