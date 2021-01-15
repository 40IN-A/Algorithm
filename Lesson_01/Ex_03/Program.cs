using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_03
{
    class Program
    {
        static long Fibonacci(long n)
        {
            if (n == 0)
            {
                return 0;
            }
            else if (n == 1)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 1) + Fibonacci(n - 2);
            }


        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите значение последовательности n вычисляющее число Фибонначи:");
            long n = Convert.ToInt64(Console.ReadLine());
            //long num = 0;
            long prev = 0;
            long current = 1;
            long next = 1;
            if (n == 0)
            {
                next = 0;
            }
            else if (n == 1)
            {
                next = 1;
            }
            else
            {
                for (int i = 2; i <= n; i++)
                {
                    next = current + prev;
                    prev = current;
                    current = next;
                }
            }
            Console.WriteLine($"Значению последовательности n = {n} соответствует число Фибоначчи равное: {next} - вычислено с помощью цикла");
            long number = Fibonacci(n);
            Console.WriteLine($"Значению последовательности n = {n} соответствует число Фибоначчи равное: {number} - вычислено с помощью рекурсии");

        }
    }
}
