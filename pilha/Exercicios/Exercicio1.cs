using System;
using System.Threading;

namespace pilha.Exercicios {
    public class Exercicio1 {

        private Pilha<int> Pilha {get; set;}
        public Exercicio1() {
            Pilha = new Pilha<int>();
        }

        public void Run() {
            int number = 0;
            Console.WriteLine("Bem - Vindo aos estudos sobre pilha");
            Console.WriteLine("A regra é a seguinte, a cada numero digitado nós fazemos uma ação");
            Console.WriteLine("Se for par empilhamos");
            Console.WriteLine("Se for impar desempilhamos um numero da pilha");

            for(int i = 0; i < 10; i++) {
                Console.Write($"Informe um número {i+1}: ");
                if(int.TryParse(Console.ReadLine(),out number)) {
                    Empilhe(number);
                    continue;
                }
                Console.WriteLine("Informe um numero correto");
                i--;
            }
            DesempilharElementos();
        }
        private void Empilhe(int number) {
            if(EnumeroPar(number)) {
                Pilha.Empilha(number);
                Console.WriteLine($"Número Empilhado {number}");
                return;
            }
            if(!Pilha.EstaVazia()) {
                Console.WriteLine($"Número Desempilhado {Pilha.Desempilhar()}");
                return;
            }
            Console.WriteLine("A pilha está vazia, impossível remover o elemento!");
        }

        private void DesempilharElementos(){
            Console.Clear();
            Console.WriteLine("Desempilhando elementos da pilha");
            for(int i = Pilha.Tamanho; i >= 0; i--) {
                Thread.Sleep(1000);
                Console.WriteLine($"Elemento {Pilha.Tamanho}: {Pilha.Desempilhar()}");                               
            }
        }
        private bool EnumeroPar(int number) {
            return number % 2 == 0;
        }
    }
}