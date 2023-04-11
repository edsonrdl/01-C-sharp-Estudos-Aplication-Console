using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace _04_Classes_e_objetos._01_Declaração_de_classes
{
    public class Pessoa
    {
        public string Nome;
        public int Idade;
        public string Endereco;

        public void ExibirResultado()
        {
            Pessoa pessoa1= new Pessoa();
            pessoa1.Nome = "Luffy";

            Pessoa pessoa2= new Pessoa();
            pessoa2.Nome = "Zoro";

            Pessoa pessoa3= new Pessoa();
            pessoa3.Nome = "Sanji";

            Console.WriteLine(pessoa1.Nome);
            Console.WriteLine(pessoa2.Nome);
            Console.WriteLine(pessoa3.Nome);

          }
    }
}
