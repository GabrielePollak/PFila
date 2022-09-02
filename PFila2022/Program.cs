using System;

namespace PFila2022
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FilaPessoa contatos = new FilaPessoa();

            contatos.Print();
            contatos.Pop();
            contatos.Push(new Pessoa("Morango", 32, "190"));
            contatos.Print();
        }
    }
}
