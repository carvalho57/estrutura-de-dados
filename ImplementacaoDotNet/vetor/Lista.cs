using System;
using Base;
namespace vetor {
    public class Lista<T> : EstruturaBasica<T>{
        
        public Lista(int capacidade) : base(capacidade) {
        }
        public Lista() : base(10) {
            
        }

        public void SetarElemento(int posicao, T elemento) {
            if(!EPosicaoInvalida(posicao)) {
                elementos[posicao] = elemento;
            }
        }

        public new bool Adicionar(T elemento) {
            return base.Adicionar(elemento);
        }


        public new bool Adicionar(int posicao,T elemento) {
           return base.Adicionar(posicao,elemento);
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
        
        public bool Remove(T elemento) {
            var indiceElemento = Busca(elemento);
            if(!(indiceElemento > -1)) {
                return false;
            }

            RemoveNaPosicao(indiceElemento);
            return true;
        }

        public new void RemoveNaPosicao(int posicao) {
            base.RemoveNaPosicao(posicao);
        }



        public void Limpar() {
            for(int i = Tamanho; i >= 0; i--) {
                elementos[i] = default(T);
            }
            Tamanho = 0;
        }
      
        public bool Contem(T elemento)  {
           var index = Busca(elemento);
            return index > -1;
        }

        public T Obtem(int posicao) {                        
            return Busca(posicao);        
        }

        public int UltimoIndice(T elemento) {

            for(int i = Tamanho - 1; i >= 0; i--) {
                if(this.elementos[i].Equals(elemento)) {
                    return i;
                }
            }
            return -1;
        }
        public T[] ToArray() {
            T[] newArray = new T[Tamanho];
            for(int i = 0; i < Tamanho; i++) {
                newArray[i] = elementos[i];
            }
            return newArray;
        }
        public void ForEach(Action<T> action) {
            for(int i = 0; i < Tamanho; i++) {
                action(elementos[i]);
            }
        }
    }
}