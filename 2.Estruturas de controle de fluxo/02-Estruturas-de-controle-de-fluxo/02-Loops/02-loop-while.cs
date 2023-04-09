using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Estruturas_de_controle_de_fluxo._02_Loops
{
    public class _02_loop_while
    {
        public void exibirResultado()
        {
            int[] num = new int[5];
            int i = 0;

            while (i<num.Length) //while--> Enquanto
            {
                num[i] = 0;
                Console.WriteLine(num[i]);
                i++;

            }
            Console.WriteLine("Fim do loop");
            {
                
            }
        }
    }
}
