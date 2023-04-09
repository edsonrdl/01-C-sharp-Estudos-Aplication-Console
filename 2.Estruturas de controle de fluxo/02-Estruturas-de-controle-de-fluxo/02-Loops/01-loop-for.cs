using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Estruturas_de_controle_de_fluxo._02_Loops
{
    public class _01_loop_for
    {
        public void exibirResultado()
        {
            int num1 = 10;
          for (int i = 0; i <= num1; i++) //Equivalentes i=i+1  i+=1  i++
            {
                Console.WriteLine(i);
            }
        }
    }
}
