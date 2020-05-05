using System;

namespace pilha.Exercicios {
    public class Livro {
        public string Nome {get;private set;}
        public string ISBN {get;private set;}
        public DateTime Lancamento {get;private set;}
        public string Autor{get;private set;}
        
        public Livro(string Nome, string ISBN, DateTime Lancamento, string Autor) {
            this.Nome = Nome;
            this.ISBN = ISBN;
            this.Lancamento = Lancamento;
            this.Autor = Autor;
        }

        public override string ToString() {
            return $"Nome: {Nome}\nISBN: {ISBN}\nLançamento: {Lancamento.Year}\nAutor: {Autor}";
        }
    }
}