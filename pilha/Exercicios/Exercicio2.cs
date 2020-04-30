using System;

namespace pilha.Exercicios {
    public class Exercicio2 {
        private Pilha<int> PilhaPar {get;set;}
        private Pilha<int> PilhaImpar {get;set;}
        public Exercicio2() {
            PilhaPar = new Pilha<int>();
            PilhaImpar = new Pilha<int>();
        }
        public void Run() {
              
            int number = 0;
            Console.WriteLine("Bem - Vindo aos estudos sobre pilha");
            Console.WriteLine("A regra é a seguinte, a cada numero digitado nós fazemos uma ação");
            Console.WriteLine("Se for par empilhamos na piliha Par");
            Console.WriteLine("Se for impar empilharemos na pilha Impar");
            Console.WriteLine("E o zero desempilha das duas pilhas");

            for(int i = 0; i < 10; i++) {
                Console.Write($"Informe um número {i+1}: ");
                if(int.TryParse(Console.ReadLine(),out number)) {
                    Empilhe(number);
                    continue;
                }
                Console.WriteLine("Informe um numero correto");
                i--;
            }
            DesempilharElementos(PilhaImpar,"Impar");
            DesempilharElementos(PilhaPar,"Par");
        }

        private void DesempilharElementos<T>(Pilha<T> pilha, string nomePilha)
        {
            Console.Clear();
            Console.WriteLine($"Desempilhando elementos da pilha {nomePilha}");
            for(int i = pilha.Tamanho; i >= 0 ; i--) 
                Console.WriteLine($"Elemento {i}: {pilha.Desempilhar()}");
            
        }

        private void Empilhe(int numero)
        {
            if(numero == 0)  {
                 Desempilhe();
                 return;
            }

            if(EImpar(numero)) {
                EmpilheNa(PilhaImpar, numero);
                return;
            }
            EmpilheNa(PilhaPar,numero);
        }

        private void EmpilheNa(Pilha<int> pilha, int valor)  {
            pilha.Empilha(valor);
        }

        private void Desempilhe() {
            var result = 0;
            if((result = PilhaImpar.Desempilhar()) != 0) {
                Console.WriteLine($"Removendo pilha Ímpar {result}");
            } else {
                Console.WriteLine("Pilha Impar esta vazia");
            }
            if((result = PilhaPar.Desempilhar()) != 0) {
                Console.WriteLine($"Removendo pilha Par {result}"); 
            } else {
                Console.WriteLine("Pilha Par esta vazia");
            }
        }


        private bool EImpar(int numero) {
            return numero % 2 != 0;
        }

    }
}