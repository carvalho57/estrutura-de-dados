using System;
using vetor;

namespace vetor.Exercicios {
    public class Exercicio5 {
        public static void Run() {
            var list = new Lista<string>();

            list.Adicionar("Arroz");
            list.Adicionar("Feijão");
            list.Adicionar("Batata");
            list.Adicionar("Frango");
            list.Adicionar("Hamburger");

            Console.WriteLine(list);
            list.Limpar();
            Console.WriteLine(list);
        }
    }
}