using System;
using System.Linq;

namespace ordenacao
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new int[] {-20,0,9,6,5,7,3,1,-6,35,80,-120,65,15};
            // var array = new int[] {4,3,2,1};
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
