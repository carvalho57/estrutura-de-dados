using System;
using System.Collections;
using System.Collections.Generic;
namespace VetoresArrayLista {
    public class UsingArrayList {
        public static void Run() {
            List<string> arrayList = new List<string>();
            arrayList.AddRange(new string[] {"A","B","C","D"});
            bool exist = arrayList.Contains("B");
            if(exist) {
                Console.WriteLine("O elemento B existe");
                int indexOfB = arrayList.IndexOf("B");
                Console.WriteLine($"O índice de B é {indexOfB}");
            }

            arrayList.ForEach(x => Console.WriteLine(x.ToString()));
        }
    }
}