using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Classes_e_objetos
{
     static public class Cliente6  
    {
        static  string Nome;
        static string Sobrenome;


        static public void CriarCliente(string nome,string sobrenome)
        {
            Nome =nome;
            Sobrenome =sobrenome;
        }
        static public void InforCliente()
        {
           Console.WriteLine("Cliente {1} {0} :", Nome,Sobrenome);
        }

    }
     //Static não permite criar estância
}
