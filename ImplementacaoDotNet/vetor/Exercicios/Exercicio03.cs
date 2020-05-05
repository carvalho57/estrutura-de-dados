using System;
using vetor;
namespace vetor.Exercicios {
    public class Exercicio3 {
        public static void Run() {
            Lista<int> list = new Lista<int>();

            list.Adicionar(1);
            list.Adicionar(2);
            list.Adicionar(3);
            list.Adicionar(4);

            Console.WriteLine(list.ToString());
            Console.Write("Remova um elemento");
            var elemento = Convert.ToInt32(Console.ReadLine());
            bool remmoveSucessed = list.Remove(elemento);
            Console.WriteLine("Removido com sucesso: "+remmoveSucessed);    
            Console.WriteLine(list.ToString());

        }
    }
}