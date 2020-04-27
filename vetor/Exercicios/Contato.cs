using System;
using System.Diagnostics.CodeAnalysis;

namespace VetoresArrayLista{
    public class Contato : IEquatable<Contato> {
        public string Nome {get; private set;}
        public string Telefone {get;private set;}
        public string Email {get; private set;}

        public Contato(string nome) {
            Nome = nome;
        }
        public Contato(string nome, string telefone,string email) {
            Nome = nome;
            Telefone = telefone;
            Email = email;
        }
        public override bool Equals(object obj) {
            return this.Equals(obj as Contato);
        }

        public bool Equals(Contato other)
        {
            if(other == null) {
                return false;
            }
            return this.GetHashCode() == other.GetHashCode();
        }

        public override int GetHashCode()
        {
            return Nome.GetHashCode();
        }

        public override string ToString() {
            return $"{Nome}\n\tTelefone: {Telefone}\n\tEmail: {Email}\n";
        }
    }
}