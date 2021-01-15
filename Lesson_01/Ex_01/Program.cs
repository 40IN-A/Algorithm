using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_01
{
    class Program
    {
        static bool SimpleNumber(uint n)
        {
            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return true;
                }
            }
            return false;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите целое положительное число:");
            uint n;
            bool success = UInt32.TryParse(Console.ReadLine(), out n);
            if (success == false)
            {
                Console.WriteLine("Вы ввели недопустимое значение");
                return;
            }


            bool d = SimpleNumber(n);
            if (d)
            {
                Console.WriteLine("Число состовное");
            }
            else
            {
                Console.WriteLine("Число простое");
            }
            Console.ReadLine();
        }
    }
}
