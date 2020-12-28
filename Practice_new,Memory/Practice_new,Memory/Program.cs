using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_new_Memory
{
    class Example
    {
        // 멤버 변수
        private int data;
        public int Data
        {
            get
            {
                return data;
            }
            set
            {
                data = value;
            }
        }

        // 생성자
        public Example(int data)
        {
            this.data = data;
        }

        // 함수
        public override string ToString()
        {
            return "Data - " + data.ToString();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Example ex1 = new Example(10);
            Example ex2 = ex1;

            // ex1의 메모리 주소값
            Console.WriteLine(ex1.GetHashCode());
            // ex2의 메모리 주소값
            Console.WriteLine(ex2.GetHashCode());

            ex2.Data = 20;

            Console.WriteLine("ex1 - " + ex1.ToString());
            Console.WriteLine("ex2 - " + ex2.ToString());
        }
    }
}
