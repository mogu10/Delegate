using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    public class Program
    {
      public  static void Main(string[] args)
        {

            Program1.Lol += Print1;
            Program1.Lol += Print2;

            Program1.Method1();  
            Console.ReadKey();
        }

        public static void Print1(int i)
        {
            Console.WriteLine(i);
        }

        public   static void Print2(int i)
        {
            Console.WriteLine("* "+i+" *");
        }

        public delegate void Print(int i);
    }

    public class Program1
    {
        public static event Program.Print Lol; //event событие 

        public static void Method1()
        {
            Random random = new Random();
            int a = random.Next(100);
            if (Lol != null) Lol(a);
        }  
    }
}
