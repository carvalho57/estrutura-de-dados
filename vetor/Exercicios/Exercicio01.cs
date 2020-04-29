using System;
using vetor;
namespace vetor.Exercicios {
    public class Exercicio1 {
        public static void Run() {
            var list = new Lista<string>();
            list.Adicionar("Brazil");
            list.Adicionar("Argentina");
            list.Adicionar("Uruguay");

            Console.WriteLine($"Contém Brazil:{list.Contem("Brazil")} ");
            Console.WriteLine($"Contém Argentina:{list.Contem("Argentina")} ");
            Console.WriteLine($"Contém Uruguay:{list.Contem("Uruguay")} ");
        }
    }
}