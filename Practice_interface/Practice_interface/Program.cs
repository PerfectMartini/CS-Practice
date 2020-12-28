using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_interface
{
    interface IATypeInterface
    {
        string GetATypeName();
        void Print();
    }
    interface IBTypeInterface
    {
        string GetBTypeName();
        void Print();
    }
    class Example : IATypeInterface, IBTypeInterface
    {
        public string GetATypeName()
        {
            return "A example";
        }
        public string GetBTypeName()
        {
            return "B example";
        }
        public void Print()
        {
            Console.WriteLine("Exmple - GetATypeName - " + GetATypeName());
            Console.WriteLine("Exmple - GetBTypeName - " + GetBTypeName());
        }
    }
    class AExample : IATypeInterface
    {
        public string GetATypeName()
        {
            return "A - Example";
        }
        public void Print()
        {
            Console.WriteLine("Exmple - GetATypeName - " + GetATypeName());

        }
    }
    class BExample : IBTypeInterface
    {
        public string GetBTypeName()
        {
            return "B - Example";
        }
        public void Print()
        {
            Console.WriteLine("Exmple - GetBTypeName - " + GetBTypeName());
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Example ex = new Example();
            ex.Print();

            AExample Aex = new AExample();
            Aex.Print();

            BExample Bex = new BExample();
            Bex.Print();
        }
    }
}
