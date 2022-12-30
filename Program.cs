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




            Console.WriteLine(" Enter emp id");

            int Emp_id = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine(" Enter emp_name");

            string Emp_name = Convert.ToString(Console.ReadLine());


            Console.WriteLine(" Enter salary");

            double Salary = Convert.ToInt32(Console.ReadLine());


            double hra = (12 * Salary) / 100;
            Console.WriteLine($" HRA : {hra}");


            double ba = (20 * Salary) / 100;
            Console.WriteLine($" BA : {ba}");


            double ta = (10 * Salary) / 100;
            Console.WriteLine($" TA : {ta}");


            double total = (double)Salary + hra + ba + ta;
            Console.WriteLine($" Salary : {total}");

            double pf = (20 * total) / 100;
            Console.WriteLine($" PF : {pf}");


            double Net_Salary = total - pf;


            Console.WriteLine($" Net Salary {Net_Salary}");


        }
    }
}
