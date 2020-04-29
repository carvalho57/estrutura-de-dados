using System;
using Base;
namespace pilha {
    public class Pilha<T> : EstruturaBasica<T> {

        public Pilha() : base() {

        }
        public Pilha(int capacidade) : base(capacidade) {

        }

        public void Empilha(T elemento) {
            base.Adicionar(elemento);
        }

        public T Desempilhar() {
            if(!EstaVazia()) {                
                T elemento = elementos[Tamanho - 1];
                elementos[--Tamanho] = default(T);
                return elemento;
            }
            return default(T);
        }
        public T Topo() {
            if(EstaVazia())
                return default(T);
            return this.elementos[Tamanho - 1];
        }
    }
}