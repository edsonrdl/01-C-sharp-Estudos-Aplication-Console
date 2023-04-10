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
        public string nome;
        public int ndade;
        public string endereco;

        public void exibirResultado()
        {
            Pessoa pessoa1= new Pessoa();
            pessoa1.nome = "Luffy";

            Pessoa pessoa2= new Pessoa();
            pessoa2.nome = "Zoro";

            Pessoa pessoa3= new Pessoa();
            pessoa3.nome = "Sanji";

            Console.WriteLine(pessoa1.nome);
            Console.WriteLine(pessoa2.nome);
            Console.WriteLine(pessoa3.nome);

          }
    }
}
