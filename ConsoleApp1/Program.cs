using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, k;

            Console.Write("Введите значение k = ");
            k = Convert.ToInt32(Console.ReadLine());

            if (k == 0)
            {
                Console.WriteLine("k не может быть равна нулю!");
                return;
            }

            for (int i = 0; i < 10; i++)
            {
                Console.Write($"Введите значение n{i + 1} = ");
                n = Convert.ToInt32(Console.ReadLine());

                if (n > 9 || n < 0)
                {
                    Console.WriteLine("Введенное вами значение не цифра!");
                    break;
                } else
                {
                    if (n % k == 0)
                    {
                        Console.WriteLine("0");
                    } else
                    {
                        Console.WriteLine($"{n}");
                    }
                }
            }
        }
    }
}
