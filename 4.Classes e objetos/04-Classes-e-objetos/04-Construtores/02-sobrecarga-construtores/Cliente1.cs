using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Classes_e_objetos._04_Construtores
{
    public class Cliente1
    {

        public string Nome;
        public string Sobrenome;
        public string Titulo;

        public Cliente1()
        {
            Titulo = "Capitão";
        }
        public Cliente1(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public string ExibirResultado()
        {
            return Nome + " " + Sobrenome;
        }
        public string ExibirResultado1()
        { 
           return Titulo;
        }
    }
}
