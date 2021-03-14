using System;

namespace lista_encadeada
{
    class Program
    {
        static void Main(string[] args)
        {
            var lista = new ListaEncadeadaSimples<int>();
            lista.Add(1);
            lista.Add(2);
            lista.Add(3);
            lista.Add(4);
            lista.Remove(2);
            return;
        }
    }
}

