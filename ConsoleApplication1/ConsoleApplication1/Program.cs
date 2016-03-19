using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Print p = Print1;
                p(i);
            }
            Console.ReadKey();
        }

        static void Print1(int i)
        {
            Console.WriteLine(i);
        }

        static void Print2(int j)
        {
            Console.WriteLine("* "+j+" *");
        }

        delegate void Print(int j);
    }
}
