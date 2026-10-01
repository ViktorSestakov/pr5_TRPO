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

            Console.Write("Введите число n = ");
            n = int.Parse(Console.ReadLine());

            Console.Write("Введите число k = ");
            k = int.Parse(Console.ReadLine());

            if (k == 0)
            {
                Console.WriteLine("На 0 делить нельзя.");
                return;
            }

            int result = 0;
            int place = 1;
            int temp = n;

            while (temp != 0)
            {
                int digit = temp % 10;
                if (digit % k == 0) digit = 0;
                result += digit * place;
                place *= 10;
                temp /= 10;
            }

            Console.WriteLine("Результат: " + result);
        }
    }
}
