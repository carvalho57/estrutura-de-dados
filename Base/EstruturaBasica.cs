using System;
using System.Text;
namespace Base
{
    public class EstruturaBasica<T>  
     {
        protected T[] elementos;
        public int Tamanho{get;protected set;}
        public EstruturaBasica(int capacidade) {
            this.elementos = new T[capacidade];
            Tamanho = 0;
        }
        public EstruturaBasica() : this(10) {

        }

        protected bool Adicionar(T elemento) {
            AumentaCapacidade();            
            if(Tamanho < elementos.Length) {
                this.elementos[Tamanho] = elemento;
                Tamanho++;
                return true;
            }
            
            return false;
        }


        protected bool Adicionar(int posicao,T elemento) {
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

        protected bool EPosicaoInvalida(int posicao) {
            return !(posicao >= 0 && posicao < elementos.Length);
        }
        protected void RemoveNaPosicao(int posicao) {
            if(EPosicaoInvalida(posicao))
                throw new ArgumentException("Posição Inválida");

            for(int i= posicao; i < Tamanho -1 ; i++) {
                elementos[i] = elementos[i + 1];
            }
            Tamanho--;
        }

        public bool EstaVazia() {
            return Tamanho == 0;
        }
        
        public override string ToString() {
            if(Tamanho == 0) 
                return "[null]";
            
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
