using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Estruturas_de_controle_de_fluxo._02_Loops
{
    public class _03_Loop_do_while
    {
        public void exibirResultado()
        {
            // Do while -->Fazer enquanto
            string senha = "123";
            string senhaUser;
            do
            { Console.Clear();
                Console.WriteLine("Digete a senha ");
                senhaUser = Console.ReadLine();
            } while (senha!=senhaUser);
            Console.WriteLine($"Senha correta");
        }
    }
}
