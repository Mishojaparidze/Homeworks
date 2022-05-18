using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework10
{
    public abstract class FileWorker
    {
        public string MaximumSize { get; set; }
        public abstract string MaximumSizeType { get; set; }
        public virtual void Read()
        {
            Console.WriteLine(MaximumSize, MaximumSizeType);
        }
        public virtual void Write()
        {
            Console.WriteLine(MaximumSize, MaximumSizeType);

        }
        public virtual void Edit()
        {
            Console.WriteLine(MaximumSize, MaximumSizeType);

        }
        public virtual void Delete()
        {
             Console.WriteLine(MaximumSize, MaximumSizeType);

        }









    }
}
