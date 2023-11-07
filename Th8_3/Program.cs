using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Th8_3
{
    internal class Program
    {
        //Task 1.3
        //Display a vertical string of 18 characters offset 5 positions from the left edge of the screen.

        /*public static void Func()
        {
            for (int i = 1; i <= 18; i++)
            {
                if (i <= 18)
                { 
                    Write("     "); 
                }
                WriteLine("*");
            }
        }*/


        //Task 2.3

        /*public static void Triangle()
        {
            Write("Enter n: ");
            int n = Convert.ToInt32(ReadLine());
            WriteLine();

            for (int i = 1; i <= n; i++)
            {
                for (int j = n; j >= i; j--)
                {
                    Write(" ");
                }
                for (int k = 1; k <= i; k++)
                {
                    Write("#");
                }
                WriteLine();
            }
        }*/


        //Task 3.3

        /*public static double Func(double x, double y)
        {
            return (x + Math.Sin(x)) / (Math.Sin(y) + y);
        }*/



        //Task 4.3

        /*public static int Max(int a, int b)
        {
            return (a > b) ? a : b;
        }*/

        static void Main(string[] args)
        {
            try
            {
                //Task 1.3

                /*Func();*/


                //Task 2.3

                /*Triangle();*/


                //Task 3.3

                /*Write($"{Func(2, 5) + Func(6, 3) + Func(1, 4):f2}");*/


                //Task 4.3

                /*Write("Enter a: ");
                int a = Convert.ToInt32(ReadLine());
                Write("Enter b: ");
                int b = Convert.ToInt32(ReadLine());
                Write("Enter c: ");
                int c = Convert.ToInt32(ReadLine());
                Write("Enter d: ");
                int d = Convert.ToInt32(ReadLine());

                int s = Max(a, b) + Max(c, d);
                Write($"\nSum of two max values: {s}");*/
            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
