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
        abstract public string MaximumSizeType { get; set; }
        public virtual void Read(string read)
        {
            Console.WriteLine(read);
        }
        public virtual void Write(string write)
        {
            Console.WriteLine(write);
        }
        public virtual void Edit(string edit)
        {
            Console.WriteLine(edit);
        }
        public virtual void Delete(string delete)
        {
            Console.WriteLine(delete);
        }
    }
}
