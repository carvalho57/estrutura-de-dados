using System;
using System.Text;

namespace VetoresArrayLista {
    public class Lista<T> {
        private T[] elementos;
        public int Tamanho{get;private set;}
        public Lista(int capacidade) {
            this.elementos = new T[capacidade];
            Tamanho = 0;
        }
        public Lista() : this(10) {
            
        }

        public bool Adicionar(T elemento) {
            AumentaCapacidade();            
            if(Tamanho < elementos.Length) {
                this.elementos[Tamanho] = elemento;
                Tamanho++;
                return true;
            }
            
            return false;
        }

   
        public bool Adicionar(int posicao,T elemento) {
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
                T[] elementosNovos = new T[this.elementos.Length * 2];

                for(int i = 0; i < this.Tamanho; i++) {
                    elementosNovos[i] = elementos[i];
                }
                this.elementos = elementosNovos;
            }
        }
        
        
        public T Busca(int posicao) {
            if(EPosicaoInvalida(posicao))
                throw new ArgumentException("Posição Inválida");
            return this.elementos[posicao];
        }

        public int Busca(T elemento) {
            for(int i = 0; i < this.Tamanho; i++) {
                if(elementos[i].Equals(elemento)) {
                    return i;
                }
            }
            return -1;
        }

        public void RemoveNaPosicao(int posicao) {
            if(EPosicaoInvalida(posicao))
                throw new ArgumentException("Posição Inválida");

            for(int i= posicao; i < Tamanho -1 ; i++) {
                elementos[i] = elementos[i + 1];
            }
            Tamanho--;
        }
        public bool Remove(T elemento) {
            var indiceElemento = Busca(elemento);
            if(!(indiceElemento > -1)) {
                return false;
            }

            RemoveNaPosicao(indiceElemento);
            return true;
        }

        public bool Contem(T elemento)  {
           var index = Busca(elemento);
            return index > -1;
        }

        public int UltimoIndice(T elemento) {

            for(int i = Tamanho - 1; i >= 0; i--) {
                if(this.elementos[i].Equals(elemento)) {
                    return i;
                }
            }
            return -1;
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