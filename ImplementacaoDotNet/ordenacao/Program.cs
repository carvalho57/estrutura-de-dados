using System;
using System.Linq;

namespace ordenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            
            var array = Input.GetPrimes();
            PrintArray(array);
            Sort.QuickSort(array);
            PrintArray(array);
        }

        static void PrintArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }
            Console.WriteLine();
        }

    }
}
