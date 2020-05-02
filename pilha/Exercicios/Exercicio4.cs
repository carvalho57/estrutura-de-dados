using System;
using System.Collections.Generic;
using System.Threading;


namespace pilha.Exercicios  {
    public enum Opcoes {
        Valida = 1,
        Invalida = 0,
        Sair = -1
    }
    public class Exercicio4 {
        private Stack<Livro> Livros {get;set;}
        public Exercicio4() {
            Livros = new Stack<Livro>(20);
            Livros.Push(new Livro("Planeta dos Macacos","456165154",DateTime.Now,"PLAS"));
            Livros.Push(new Livro("O Silêncio da Casa Fria","6534541568",DateTime.Now,"PLAS"));
            Livros.Push(new Livro("O mago","8594541856",DateTime.Now,"PLAS"));
            Livros.Push(new Livro("Star Wars 3","5465465465",DateTime.Now,"PLAS"));
            Livros.Push(new Livro("Outlast","9874563446",DateTime.Now,"PLAS"));
            Livros.Push(new Livro("Resident Evil","6543894663",DateTime.Now,"PLAS"));
        }
        public void Run() { 
            ConsoleKey key = ConsoleKey.A;
            int opcao = -1;
            Opcoes opcaoEscolhida = Opcoes.Sair;          
            do {           
                ApresentarOpcoes();     
                if(!int.TryParse(Console.ReadLine(),out opcao)) {
                    EscreverMensagem("A opção informada deve ser um número!");                    
                    continue;
                }

                if((opcaoEscolhida = ExecutarOpcao(opcao)).Equals(Opcoes.Sair)) {
                    EscreverMensagem("Volte Sempre!",2);
                    break;
                } 

                if(opcaoEscolhida.Equals(Opcoes.Invalida))
                    continue;
                
                Console.Write("Precione Esc para sair...");
                key = Console.ReadKey().Key;
            } while(!key.Equals(ConsoleKey.Escape));
            
        }
        public void ApresentarOpcoes() {
            Console.Clear();
            Console.WriteLine("Bem Vindo - A pilha de livros");            
            Console.WriteLine("1 - Empilhar um livro");
            Console.WriteLine("2 - Desempilhar");
            Console.WriteLine("3 - Verificar qual o livro está no topo");
            Console.WriteLine("0 - Sair");
            Console.Write("Informe a opção desejada: ");
        }
        public Opcoes ExecutarOpcao(int opcao) {
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
                case 0:
                    Console.WriteLine("Obrigado pelo seu tempo!");
                    return Opcoes.Sair;             
                default:
                    EscreverMensagem("A opção informada não é válida!");
                    return Opcoes.Invalida;                  
           }
           return  Opcoes.Valida;
        }
        public void EscreverMensagem(string mensagem, int tempoMensagemSegundo = 3) {
            Console.WriteLine("-----------------------------");
            Console.WriteLine(mensagem);
            Console.WriteLine("-----------------------------");
            PausarExecucao(tempoMensagemSegundo);
        }
        public void PausarExecucao(int segundo) {
            Thread.Sleep(segundo * 1000);
        }
        public void ElementoTopo() {                
            var livro = Livros.Peek();
            Console.WriteLine("Livro no Topo da Pilha - >");
            Console.WriteLine(livro);
        }
        public void Empilhar() {                               
          Console.WriteLine("Insira as informações do livro: ");
          var nome = LerInformacao("Informe o nome");
          var isbn = LerInformacao("Informe o ISBN");
          DateTime lancamento = new DateTime();
          if( !DateTime.TryParse(
                LerInformacao("Informe o lancamento no formato (YYYY/MM/DD)"),
                out lancamento) ) {

                EscreverMensagem("Informe a data de lançamento no formato");
                return;
          }

          var autor = LerInformacao("Informe o nome do autor");          
          Livros.Push(new Livro(nome,isbn,lancamento,autor));
          Console.Clear();
          Console.WriteLine($"Livro empilhado com sucesso\n {Livros.Peek()}");

        }
        public string LerInformacao(string mensagem) {
            Console.Write($"{mensagem}: ");
            return Console.ReadLine();
        }
        public void Desempilhar() {            
            Console.WriteLine("Desempilhando o último elemento");
            Console.WriteLine(Livros.Pop());
        }
    }
}