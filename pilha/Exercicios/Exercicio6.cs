using System;
using System.Collections.Generic;
/*
Exercício 06 
Exercício 06 
Desafio dos símbolos balanceados Escreva um programa para verificar se uma expressão matemática tem os parênteses agrupados de forma correta, isto é: 
    (1) se o número de parênteses à esquerda e à direita são iguais e;
    (2) se todo parêntese aberto é seguido posteriormente por um fechamento de parêntese. Veja alguns exemplos:

 As expressões 
    ((A+B) ou A+B(
        violam a condição 1 -
As expressões 
    )A+B( – C  ou  (A+B)) – (C + D 
        violam a condição 2 - 
A expressão ((A+B)+D) está ok 
(A+B)) – (C -> (A+B))–(C  -> ())( 
)A+B( – C -> )A+B(–C -> )(
((A+B) -> ((A+B) - > (()
A+B( - > A+B( -> (
(A + (B+C)) -> (()) 
Soma de parentes abertos tem que ser igual a dos fecha parenteses
*/
namespace pilha.Exercicios {
    public class Exercicio6 {
        public void Run() {
            Console.Write("Símbolos Balanceados");
            Console.WriteLine(" (1) se o número de parênteses à esquerda e à direita são iguais e");
            Console.WriteLine("(2) se todo parêntese aberto é seguido posteriormente por um fechamento de  parêntese. Veja alguns exemplos:");
            var expressao = Utilitario.LerInformacao("/n/n Informe a expressão e iremos validar baseado nas regras 1 e 2: ");
            var result = VerificarOrdem(ApenasParenteses(expressao.Trim()));
            Console.WriteLine(result);
        }

        private Pilha<char> ApenasParenteses(string expressao)  {
            var parenteses = new Pilha<char>(4);
            for(int i = 0; i  < expressao.Length; i++) {
                if(expressao[i] == '(' || expressao[i] == ')')
                    parenteses.Empilha(expressao[i]);
            }
            return parenteses;
        }    

        private bool VerificarOrdem(Pilha<char> parenteses) {            
            if(parenteses.Topo() == '(')
                return false;

            int control = 0;            
            while(!parenteses.EstaVazia()) {                
                if(parenteses.Desempilhar() == ')') {
                    control++;
                    continue;
                }
                control--;
            }
            return control == 0 && parenteses.Tamanho % 2 == 0;
        }
        
    }
}