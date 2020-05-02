using System;
using System.Threading;


namespace pilha.Exercicios {

    public static class Utilitario {
        public static string LerInformacao(string mensagem)     {
            Console.Write(mensagem);
            return Console.ReadLine();
        }

        public static void PausarExecucao(int segundo) {
            Thread.Sleep(segundo * 1000);
        }

        public static void EscreverMensagem(string mensagem, int tempoMensagemSegundo = 3) {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine(mensagem);
            Console.WriteLine("-----------------------------------------");
            PausarExecucao(tempoMensagemSegundo);
        }
    }
}
