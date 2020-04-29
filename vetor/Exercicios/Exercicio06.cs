using System;
using System.Threading;
using vetor;
namespace vetor.Exercicios {
    public class Exercicio6 {

        private Lista<Contato> Contatos {get;set;}
        public Exercicio6() {
            Contatos = new Lista<Contato>(20);
            Contato[] conts = new Contato[] {
                new Contato("Gabriel","4184156739","gabriel@outlook.com"),
                new Contato("Guilherme","4184156739","guilherme@outlook.com"),
                new Contato("Diego","4184156739","diego@outlook.com"),
                new Contato("Thiago","4184156739","thiago@outlook.com"),
                new Contato("Carlos","4184156739","carlos@outlook.com"),
                new Contato("Evelin","4184156739","evelin@outlook.com"),
                new Contato("Amanda","4184156739","amanda@outlook.com"),
            };

            for(int i = 0, j = 0; i <= 30; i++, j++) {                
                if(j == 6)
                    j = 0;
                Contatos.Adicionar(
                    new Contato(conts[j].Nome + i, conts[j].Telefone + i, conts[j].Email + i)
                );
            }
        }
        public void Run() {            
            ConsoleKey key;
            do {
                Console.WriteLine("Bem - Vindo ao gerenciador de contatos");
                Console.WriteLine("Escolha uma das opções");
                ApresentarOpcoes();               
                Console.WriteLine("Precione ESC para sair!");
                key  = Console.ReadKey().Key;
                Console.Clear();
            } while(key != ConsoleKey.Escape);
        }
        private void ExecutarOperacaoEscolhida(int operation) {
            Console.Clear();
            switch(operation) {
                case 0:
                    VisualizarTodososContatos();
                    break;
                case 1: 
                    AdicionarContato();
                    break;
                case 2:
                    RemoverContato();
                    break;
                case 3:
                    LimparTodosContatos();
                    break;
                case 4: 
                    BuscarContatoPeloNome();
                    break;
                case 5: 
                    AtualizarContato();
                    break;
                default:
                    Console.Clear(); 
                    for(int i =3 ; i >=0; i--) {
                        Console.WriteLine("Erro operação inválida");                                    
                        Console.WriteLine($"Escolha um opção válida em {i}s");
                        Thread.Sleep(1000);                        
                        Console.Clear();
                    }
                    ApresentarOpcoes();
                    break;                
            }
        }
        private void ApresentarOpcoes() {
                
            Console.WriteLine("Opções Contatos");
            Console.WriteLine("0 - Visualizar todos os contatos");
            Console.WriteLine("1 - Adicionar Contato:");
            Console.WriteLine("2 - Remover Contato:");
            Console.WriteLine("3 - Limpar todos os Contatos");                
            Console.WriteLine("4 - Buscar contato pelo nome");            
            Console.WriteLine("5 - Atualizar Contato");
            
            int opcao = 0;
            Console.Write("Informe a opção: ");
            var opcaoDigitada = Console.ReadLine();
            if(int.TryParse(opcaoDigitada,out opcao)) {
                ExecutarOperacaoEscolhida(opcao);                    
            }               
            
        }
        private void VisualizarTodososContatos() {
            var contatos = Contatos.ToArray();
            if(contatos.Length == 0) {
                Console.WriteLine("Não existe nenhum contato");
                return;
            }
            
            foreach(var contato in contatos) {
                Console.WriteLine(contato);
            }
        }
        private void AdicionarContato() {            
            Console.WriteLine("Adicionando Contato");
            Console.Write("Informe o nome: ");
            var nome = Console.ReadLine();
            Console.Write("Informe o telefone: ");
            var telefone = Console.ReadLine();
            Console.Write("Informe o email: ");
            var email = Console.ReadLine();

            this.Contatos.Adicionar(new Contato(nome,telefone,email));
        }

        private void RemoverContato() {
            Console.Write("Informe o nome: ");
            var nome = Console.ReadLine();
            var indiceContato = BuscarIndiceContatoPeloNome(nome);
            if(indiceContato  > -1) {
                Console.Write("Tem certeza que deseja remover o contato [yes/no]? ");
                if(ReceberConfirmacao()) {  
                    Contatos.RemoveNaPosicao(indiceContato);
                    Console.WriteLine("Contato Removido com sucesso");
                    Thread.Sleep(2000);
                    return;
                }              
            }
            Console.WriteLine("Contato inexistente");
        }
        private void BuscarContatoPeloNome() {
            Console.Write("Informe o nome: ");
            var nome = Console.ReadLine();
            var indiceContato = BuscarIndiceContatoPeloNome(nome);
            if(indiceContato > -1) {
                var contato = Contatos.Obtem(indiceContato);
                Console.WriteLine(contato);
                Console.ReadKey();
            }
        }        

        private void AtualizarContato() {
            Console.WriteLine("Atualizando contato");            
            Console.Write("Informe o nome: ");
            var nome = Console.ReadLine();
            var indiceContato = BuscarIndiceContatoPeloNome(nome);
            if(indiceContato > -1) {
                Console.WriteLine("O Contato Existe");
                Console.WriteLine("Informe os novos dados");
                Console.Write("Informe o nome: ");
                nome = Console.ReadLine();
                Console.Write("Informe o telefone: ");
                var telefone = Console.ReadLine();
                Console.Write("Informe o email: ");
                var email = Console.ReadLine();

                Contatos.SetarElemento(indiceContato, new Contato(nome,telefone,email));
            }
        }

        
        private void LimparTodosContatos() {
            Console.Write("Tem certeza que deseja remover todos os contatos [yes/no]? ");
            if(ReceberConfirmacao()) {
                Contatos.Limpar();                
            }
        }
        private bool ReceberConfirmacao() {
            if(Console.ReadLine() == "yes")
                return true;
            return false;
        }
        private int BuscarIndiceContatoPeloNome(string nome) {
            var contatos = Contatos.ToArray();
            for(int i = 0; i < contatos.Length; i++) {
                if(contatos[i].Nome.Equals(nome)) {
                    return i;
                }
            }
            return -1;
        }
    }
}

