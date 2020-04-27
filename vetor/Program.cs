using System;

namespace VetoresArrayLista
{
    class Program
    {
        static void Main(string[] args) {
            //GenericVetors();
            //UsingArrayList.Run();
            //Exercicios.Exercicio1.Run();
            //Exercicios.Exercicio2.Run();
            //Exercicios.Exercicio3.Run();
            //Exercicios.Exercicio4.Run();            
            //Exercicios.Exercicio5.Run();            
            var exericicio6 = new Exercicios.Exercicio6();
            exericicio6.Run();
        }

        static void GenericVetors() {
            var vetor = new Lista<string>(2);
            vetor.Adicionar("Gabriel");
            vetor.Adicionar("Feo");
            vetor.Adicionar("De");
            vetor.Adicionar("Carvalho");

            Console.WriteLine($"Tamanho: {vetor.Tamanho}");
            if(vetor.Busca("Gabriel") > -1) {
                Console.WriteLine("Elemento Gabriel Existe");
            } else {
                Console.WriteLine("Elemento buscado não existe");
            }            
            Console.WriteLine(vetor);

        }
        static void CommumVetor() {
              Vetor vetor = new Vetor(2);
        
            vetor.Adicionar("elemento 1");
            vetor.Adicionar("elemento 2");
            vetor.Adicionar("elemento 3");
            vetor.Adicionar("elemento 4");
            vetor.Adicionar("elemento 5");

         
            Console.WriteLine($"Elementos: {vetor.ToString()}");
            Console.WriteLine($"Tamanho: {vetor.Tamanho}");
            // Console.WriteLine($"Elemento posição -1: {vetor.Busca(-1)}");
            Console.WriteLine($"Elemento posição 3: {vetor.Busca(2)}");
            Console.WriteLine($"Posição do Elemento: {vetor.Busca("elemento 4")}");
            Console.WriteLine($"Posição do Elemento: {vetor.Busca("elemento -1")}");

            vetor.Adicionar(0,"Elemento 0");
            Console.WriteLine($"Elementos: {vetor.ToString()}");
            vetor.Adicionar(3,"elemento 3");
            Console.WriteLine($"Elementos: {vetor.ToString()}");
            Console.WriteLine("Removendo elemento da posição 2");
            vetor.Remove(2);
            Console.WriteLine($"Elementos: {vetor.ToString()}");
            Console.ReadKey();
        }
    }
}

