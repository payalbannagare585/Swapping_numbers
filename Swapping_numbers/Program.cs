using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swapping_numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a,b;

            Console.WriteLine("enter value of a: ");
            a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("enter value of b: ");
            b=Convert.ToInt32(Console.ReadLine());  

            //swapping
            a = a + b;
            b = a - b;
            a = a - b;

            Console.WriteLine("Values after swapping are:");
            Console.WriteLine("a=" + a);
            Console.WriteLine("b=" + b);
        }
    }
}
