using System;
using System.Text;

namespace VetoresArrayLista {
    public class Vetor {
        private string[] elementos;
        public int Tamanho{get;private set;}
        public Vetor(int capacidade) {
            this.elementos = new string[capacidade];
            Tamanho = 0;
        }

        public bool Adicionar(string elemento) {
                  
            if(Tamanho < elementos.Length) {
                this.elementos[Tamanho] = elemento;
                Tamanho++;
                return true;
            }
            AumentaCapacidade();      
            return false;
        }

   
        public bool Adicionar(int posicao,string elemento) {
            if(EPosicaoInvalida(posicao))
                return false;
            AumentaCapacidade();
            //mover todos os elementos
            for(int i = Tamanho; i > posicao; i--) {
                elementos[i] = elementos[i - 1];
            }
            this.elementos[posicao] = elemento;
            this.Tamanho++;

            return true;
        }

        private void AumentaCapacidade() {
            if(this.Tamanho == this.elementos.Length) {
                string[] elementosNovos = new string[this.elementos.Length * 2];

                for(int i = 0; i < this.Tamanho; i++) {
                    elementosNovos[i] = elementos[i];
                }
                this.elementos = elementosNovos;
            }
        }
        
        
        public string Busca(int posicao) {
            if(EPosicaoInvalida(posicao))
                throw new ArgumentException("Posição Inválida");
            return this.elementos[posicao];
        }

        public int Busca(string elemento) {
            for(int i = 0; i < this.Tamanho; i++) {
                if(elementos[i] == elemento) {
                    return i;
                }
            }
            return -1;
        }

        public void Remove(int posicao) {
            if(EPosicaoInvalida(posicao))
                throw new ArgumentException("Posição Inválida");

            for(int i= posicao; i < Tamanho -1 ; i++) {
                elementos[i] = elementos[i + 1];
            }
            Tamanho--;
        }

        private bool EPosicaoInvalida(int posicao) {
            return !(posicao >= 0 && posicao < elementos.Length);
        }

        public override string ToString() {
            var str = new StringBuilder();
            str.Append("[");
            for(int i =0; i < Tamanho-1;i++) {
                str.Append($"{elementos[i]}, ");
            }
            str.Append($"{elementos[Tamanho-1]}");

            str.Append("]");
            return str.ToString();
        }
    }
}