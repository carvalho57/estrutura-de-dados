using System;

namespace recursividade
{
    class Program
    {
        static void Main(string[] args)
        {
            var recursion = new Recursion();
            var result = recursion.Power(3,-1);
            Console.WriteLine(result);
        }
    }
}
