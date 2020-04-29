using System;
using System.Collections.Generic;
namespace vetor {
    public class UsingArrayList {
        public static void Run() {
            var arrayList = new List<string>();
            arrayList.AddRange(new string[] {"A","B","C","D"});
            bool exist = arrayList.Contains("B");
            if(exist) {
                Console.WriteLine("O elemento B existe");
                int indexOfB = arrayList.IndexOf("B");
                Console.WriteLine($"O índice de B é {indexOfB}");
            }
            
            var result = arrayList.Remove("E");
            Console.WriteLine($"Foi possivel remover {result}");
            arrayList.ForEach(x => Console.WriteLine(x.ToString()));
            
        }
    }
}