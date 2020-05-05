using System;
using System.Collections.Generic;
using System.Threading;

namespace pilha.Exercicios {
    public class Exercicio3 {
        private Pilha<Livro> Livros {get;set;}
        public Exercicio3() {
            Livros = new Pilha<Livro>(20);
            Livros.Empilha(new Livro("Planeta dos Macacos","456165154",DateTime.Now,"PLAS"));
            Livros.Empilha(new Livro("O Silêncio da Casa Fria","6534541568",DateTime.Now,"PLAS"));
            Livros.Empilha(new Livro("O mago","8594541856",DateTime.Now,"PLAS"));
            Livros.Empilha(new Livro("Star Wars 3","5465465465",DateTime.Now,"PLAS"));
            Livros.Empilha(new Livro("Outlast","9874563446",DateTime.Now,"PLAS"));
            Livros.Empilha(new Livro("Resident Evil","6543894663",DateTime.Now,"PLAS"));
        }
        public void Run() { 
            ConsoleKey key = ConsoleKey.A;
            int opcao = -1;
            bool opcaoValida = false;          
            do {           
                ApresentarOpcoes();     
                if(!int.TryParse(Console.ReadLine(),out opcao)) {
                    Utilitario.EscreverMensagem("A opção informada deve ser um número!");                    
                    continue;
                }

                if( (opcaoValida = ExecutarOpcao(opcao)) == false ) {
                   Utilitario.EscreverMensagem("A opção informada não é válida!");
                    continue;
                }
                
                Console.Write("Precione Enter para sair...");
                key = Console.ReadKey().Key;
            } while(!key.Equals(ConsoleKey.Enter));
            
        }
        public void ApresentarOpcoes() {
            Console.Clear();
            Console.WriteLine("Bem Vindo - A pilha de livros");            
            Console.WriteLine("1 - Empilhar um livro");
            Console.WriteLine("2 - Desempilhar");
            Console.WriteLine("3 - Verificar qual o livro está no topo");  
            Console.Write("Informe a opção desejada: ");
        }
        public bool ExecutarOpcao(int opcao) {
            Console.Clear();
           switch(opcao) {
                case 1: 
                    Empilhar();
                    break;                    
                case 2:
                    Desempilhar();
                    break;                    
                case 3: 
                    ElementoTopo();
                    break;                  
                default:
                    Console.WriteLine("Opção Inválida");
                    return false;                  
           }
           return  true;
        }      
     
        public void ElementoTopo() {                
            var livro = Livros.Topo();
            Console.WriteLine("Livro no Topo da Pilha - >");
            Console.WriteLine(livro);
        }
        public void Empilhar() {                               
          Console.WriteLine("Insira as informações do livro: ");
          var nome = Utilitario.LerInformacao("Informe o nome");
          var isbn = Utilitario.LerInformacao("Informe o ISBN");
          DateTime lancamento = new DateTime();
          if( !DateTime.TryParse(
                Utilitario.LerInformacao("Informe o lancamento no formato (YYYY/MM/DD)"),
                out lancamento) ) {

                Utilitario.EscreverMensagem("Informe a data de lançamento no formato");
                return;
          }

          var autor = Utilitario.LerInformacao("Informe o nome do autor");          
          Livros.Empilha(new Livro(nome,isbn,lancamento,autor));
          Console.Clear();
          Console.WriteLine($"Livro empilhado com sucesso\n {Livros.Topo()}");

        }
        public void Desempilhar() {            
            Console.WriteLine("Desempilhando o último elemento");
            Console.WriteLine(Livros.Desempilhar());
        }
    }    
}