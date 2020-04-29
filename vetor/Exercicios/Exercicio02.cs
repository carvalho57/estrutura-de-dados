using System;

namespace vetor.Exercicios {
    public class Exercicio2 {
        public static void Run() {
            var list = new Lista<string>();
            list.Adicionar("Brazil");
            list.Adicionar("Argentina");
            list.Adicionar("Uruguay");
            list.Adicionar("Brazil");
            list.Adicionar("Paraguay");
            int index = list.UltimoIndice("Brazil");
            Console.WriteLine($"Ultimo Indice onde está o Brazil: {index}");

        }
    }
}