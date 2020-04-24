using System;

namespace VetoresArrayLista.Exercicios {
    public class Exercicio4 {
        public static void Run() {
            Lista<int> list = new Lista<int>();

            list.Adicionar(1);
            list.Adicionar(2);
            list.Adicionar(3);
            list.Adicionar(4);

            Console.WriteLine($"Elemento posicao 0: {list.Obtem(0)}");
            Console.WriteLine($"Elemento posicao 2: {list.Obtem(2)}");
            Console.WriteLine($"Elemento posicao 3: {list.Obtem(3)}");
        }
    }
}