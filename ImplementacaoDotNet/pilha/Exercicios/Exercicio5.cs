using System;
/*Desafio do Palíndromo Escreva um programa que testa se uma sequência de caracteres fornecida pelo usuário é um palíndromo, ou seja, é uma palavra cuja primeira metade é simétrica à segunda metade. Veja alguns exemplos:
 - AABCCBAA - sim - ADDFDDA - sim - ABFFBB - não 
*/
namespace pilha.Exercicios {
    public class Exercicio5 {
        public void Run() {
            Console.WriteLine("Teste do Palíndromo");
            var palavra = Utilitario.LerInformacao("Informe uma palavra: ");
            Console.WriteLine("Agora vamos verificar se é um Palíndromo");
            if(VerificarPalindromo(palavra)){
                Console.WriteLine("É um Palindromo");
                return; 
            }
            Console.WriteLine("Não é um Palindromo");            
        }

        private bool VerificarPalindromo(string palavra) {
            int TamanhoMetade = (int)(palavra.Length/2);
            var primeiraMetade = new Pilha<char>(TamanhoMetade);
            var segundaMetade = new Pilha<char>(TamanhoMetade);
            
            for(int i = 0, j = palavra.Length - 1; i < TamanhoMetade && j >= TamanhoMetade; i++, j--) {
                primeiraMetade.Empilha(palavra[i]);
                segundaMetade.Empilha(palavra[j]);
            }

            return primeiraMetade.Equals(segundaMetade);
        }
    }
}