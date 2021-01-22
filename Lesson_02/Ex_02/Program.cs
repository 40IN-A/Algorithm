using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_02
{
    class Program
    {
        static int BinarrySearch(int[] array, int target)
        {
            int min = 0;
            int max = array.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                //Console.WriteLine($"{array[mid]}");
                if (target == array[mid])
                {
                    return array[mid];          // Асимптотическая сложность данного алгоритма равна O(log N).
                }                               
                else if (target > array[mid])   
                {
                    min = mid + 1;
                }
                else
                {
                    max = mid - 1;
                }
            }
            //Console.WriteLine("Ne popal");
            return -1; 
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число");
            int target = Convert.ToInt32(Console.ReadLine());
            int[] array = { 1, 2, 3, 15, 24, 55, 77 };
            int answer = BinarrySearch(array, target);
            if ( answer == -1 )
            {
                Console.WriteLine($"Введенное число: {target} в массиве отсутствует.");
            }
            else
            {
                Console.WriteLine($"Введенное число: {target} в массиве присутствует.");
            }
        }
    }
}
