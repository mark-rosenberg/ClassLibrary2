using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary2;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Class1 cls1 = new Class1();
            Console.WriteLine(cls1.Count(10000000));
            Console.ReadKey();
        }
    }
}
