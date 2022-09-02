using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PFila2022
{
    internal class FilaPessoa
    {
        public Pessoa HEAD { get; set; }
        public Pessoa Tail { get; set; }

        public FilaPessoa()
        {
            HEAD = Tail = null;
        }

        public void Push(Pessoa aux)
        {
            if (Vazia())
                HEAD = Tail = aux;
            else
            {
                Tail.Proximo = aux;
                Tail = aux;
            }
            Console.WriteLine("Insirido com sucesso!");
            Console.ReadKey();

        }

        public void Pop()
        {
            if (Vazia())
            {
                Console.WriteLine("Impossivel! Fila vazia!");
            }
            else
            {
                HEAD = HEAD.Proximo;
                if (HEAD == null)
                    Tail = null;

            }
        }

        public void Print()
        {
            if (Vazia())
                Console.WriteLine("Fila Vazia");
            else
            {
                Pessoa aux = HEAD;
                do
                {
                    Console.WriteLine(aux.ToString());
                    aux = aux.Proximo;
                }while (aux != null);
                Console.WriteLine("Fim da impressão!");
            }
            
        }
        
        
        private bool Vazia()
        {
            if ((HEAD == null) && (Tail == null))
                return true;
            else
                return false;
        }
    }
}
