using System;

namespace CodingClass1
{
    class Program
    {
        static void Main(string[] args)
        {
            double p = 0;
            double qarea = 1;
            double v = 0;
            double a, b;
            double h;
            string f;
            bool con = true;
            while (con)
            {


                Console.WriteLine("Welcome to Grand Circus' Room Detail Generator ");
                Console.WriteLine(" Enter Length:");
                a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Width: ");
                b = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter Height: ");
                h = double.Parse(Console.ReadLine());
                p = 2 * a + 2 * b;
                qarea = a * b;
                v = a + b + h;
               
                Console.WriteLine("Area is :" + qarea);
                Console.WriteLine("Perimeter is: " + p);
                Console.WriteLine("Volume is: " + v);
                Console.WriteLine("Do you want to continue? Please type Y or N");
                f = Console.ReadLine();
                
                if (f == "y" || f == "Y")
                {
                    con = true;
                   
                }
                else 
                {
                    con = false;
                }
               
            }

        }
    }
}
