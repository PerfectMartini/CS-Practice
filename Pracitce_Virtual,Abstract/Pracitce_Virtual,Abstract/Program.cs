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
    class Example1 : AbstractExample
    {
        protected override string GetData()
        {
            return "Example1";
        }
    }
    class Example2 : AbstractExample
    {
        protected override string GetData()
        {
            return "Example2";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            AbstractExample[] array = new AbstractExample[]
            {
                new Example1(), new Example2()
            };

            foreach (var ex in array)
            {
                ex.Print();
            }
        }
    }
}
