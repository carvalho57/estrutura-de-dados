using System;
using System.Diagnostics.CodeAnalysis;
using Base;
namespace pilha {
    public class Pilha<T> : EstruturaBasica<T>, IEquatable<Pilha<T>> {

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

        public bool Equals(Pilha<T> outro)
        {
            if(outro == null) 
                return false;
            if(outro.Tamanho != this.Tamanho)
                return false;        
            for(int i = 0; i < outro.Tamanho; i++) {
                if(!this.elementos[i].Equals( outro.elementos[i] ) ) {
                    return false;
                }
            }
            return true;
        }
    }
}