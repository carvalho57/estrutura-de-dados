using System;
using System.Collections.Generic;
using System.Text;
/*
Exercício 07 
Desafio conversão decimal-binário Usando a classe Pilha ou Stack, desenvolva um algoritmo que faça a conversão de números decimais para binário.
3. 3 
*/
namespace pilha.Exercicios {
    public class Exercicio7 {
        public void Run() {
            Console.WriteLine("Conversão Decimal - Binário");
            int valorDecimal = 0;
            if( !int.TryParse(Utilitario.LerInformacao("Informe o valor decimal: "), out valorDecimal)) {
                Utilitario.EscreverMensagem("Informe um número");
                return;
            }
            var valorBinario = ConverteDecimalBinario(valorDecimal);
            PrintBinarios(valorBinario);
        }
        private void PrintBinarios(Pilha<char> binarios) {
            var binario = new StringBuilder();
            while(!binarios.EstaVazia()) {
                binario.Insert(0,binarios.Desempilhar());
            }
            Console.WriteLine(binario.ToString());
        }
        
        private Pilha<char> ConverteDecimalBinario(int valor) {
            var binarios = new Pilha<char>(8);
            int result = 0;
            int valorPotencia = 0;
            for(int i = 7; i >= 0; i--) {
                valorPotencia = Pow(2,i);
                if( (result = (valor - valorPotencia)) >= 0 )  {
                    valor = result;
                    binarios.Empilha('1');
                    continue;
                }
                binarios.Empilha('0');
            }
            return binarios;
        }

        private int Pow(int valorBase, int expoente) {
            if(expoente == 0) {
                return 1;
            }
            return valorBase  * Pow(valorBase,expoente - 1);
        }
    }
}