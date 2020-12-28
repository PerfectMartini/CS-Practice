using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pracitce_Virtual_Abstract
{
    abstract class AbstractExample
    {
        public void Print()
        {
            Console.WriteLine("GetData function - " + GetData());
        }

        protected abstract string GetData();
    }
    class Example : AbstractExample
    {
        protected override string GetData()
        {
            return "Hello world";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Example ex = new Example();
            ex.Print();
        }
    }
}
