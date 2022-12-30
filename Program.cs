using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Wthout using thrid variable

            Console.WriteLine(" X =");
            int X = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" Y =");
            int Y = Convert.ToInt32(Console.ReadLine());


            X = X + Y;
            Y = X - Y;
            X = X - Y;

            Console.WriteLine($"  X = {X}");
            Console.WriteLine($"  Y = {Y}");



            //using thrid variable

            Console.WriteLine(" A =");
            int A = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(" B =");
            int B = Convert.ToInt32(Console.ReadLine());

            int C = A;
            A = B;
            B = C;

            Console.WriteLine($"  A = {A}");
            Console.WriteLine($"  B = {B}");

        }
    }
}
