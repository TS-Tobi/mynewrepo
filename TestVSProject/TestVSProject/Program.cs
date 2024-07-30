using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestVSProject
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World");

            int number = Double(3);
            Console.WriteLine(number);

            Console.ReadKey();
        }
        static int Double(int num)
        {
            return num * 2;
        }
    }
}
