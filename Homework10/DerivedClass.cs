using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    internal class DerivedClass : FileWorker
    {
        public override string MaximumSizeType { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }


        public override void Read()
        {
            Console.WriteLine($"I can Write TXT {MaximumSizeType} with max storage {MaximumSize}");
            
        }
        public override void Write() 
        {
            Console.WriteLine($"I can read from {MaximumSizeType} file with max storage {MaximumSize}");
            
        }
        public override void Edit()
        {
            Console.WriteLine($"I can edit from {MaximumSizeType} file with max storage {MaximumSize}");
           
        }
        public override void Delete() 
        {
            Console.WriteLine($"I can delete from {MaximumSizeType} file with max storage {MaximumSize}");
            

        }


    }
}
