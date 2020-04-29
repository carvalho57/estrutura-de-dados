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
    }
}