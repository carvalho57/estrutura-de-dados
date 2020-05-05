using System;
using System.Collections.Generic;

namespace pilha {
    public class UsingStack {
        public static void Run() {
            var stack = new Stack<int>();

            stack.Push(1);
            stack.Push(2);
            stack.Push(3);

            Console.WriteLine($"Count: {stack.Count}");
            Console.WriteLine($"ultimo elemento: {stack.Pop()}");
            Console.WriteLine($"Verificando ultimo elmenento da pilha: {stack.Peek()}");
            
        }
    }
}
