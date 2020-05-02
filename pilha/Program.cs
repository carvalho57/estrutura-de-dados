using System;

namespace pilha
{
    class Program
    {
        static void Main(string[] args)
        {
            Exercicios();
        }

        static void UsingPilha() {
             var pilha = new Pilha<int>();
            Console.Write("Informe a quantidade de elementos: ");
            var elemento = int.Parse(Console.ReadLine());
            for(int i = 0; i < elemento; i++) {
                pilha.Empilha(i);
            }
            Console.WriteLine("Verificando se a pilha está vazia");
            Console.WriteLine($"Está vazia {pilha.EstaVazia()}");
            Console.WriteLine("Verificando os elementos da pilha");
            Console.WriteLine(pilha);
            Console.WriteLine($"Quantos elementos tem na pilha:  {pilha.Tamanho}");
            Console.WriteLine($"Qual o elemento do TOPO {pilha.Topo()}");
            Console.WriteLine("Retirando o ultimo elmento");
            Console.WriteLine($"Elemento {pilha.Tamanho}: {pilha.Desempilhar()}");
            Console.WriteLine(pilha);
            
        }

        static void Exercicios() {
            //new pilha.Exercicios.Exercicio1().Run();
            //new pilha.Exercicios.Exercicio2().Run();
            //new pilha.Exercicios.Exercicio3().Run();
            //new pilha.Exercicios.Exercicio4().Run();
            new pilha.Exercicios.Exercicio5().Run();
        }
    }
}
