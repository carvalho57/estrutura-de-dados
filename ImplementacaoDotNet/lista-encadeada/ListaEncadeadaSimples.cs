using System;

namespace lista_encadeada
{
    public class ListaEncadeadaSimples<T>
    {
        private Node<T> Head { get; set; }
        private Node<T> Tail { get; set; }
        public int Length { get; set; }

        public void Add(T value)
        {
            var node = new Node<T>(value);
            if (Head == null)
            {
                Head = node;
            }
            else
            {
                Tail.Next = node;
            }
            Length++;
            Tail = node;

        }

        public void Remove(int index)
        {
            if (index > (Length - 1))
                throw new ArgumentOutOfRangeException();

            Length--;

            if (index == 0)
            {
                Head = Head.Next;
                return;
            }

            Node<T> previous = null;
            Node<T> actual = Head;
            for (int i = 0; i < index; i++)
            {
                previous = actual;
                actual = actual.Next;
            }
            previous.Next = actual.Next;
            actual.Next = null;            
        }
    }
}