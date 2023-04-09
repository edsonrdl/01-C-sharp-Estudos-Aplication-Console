using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Estruturas_de_controle_de_fluxo._02_Loops
{
    public class _04_ForEach
    {
        public void exibirResultado()
        {
            int[] num = new int[3] { 23, 43, 5 };

            foreach (int teste in num)
            {
                Console.WriteLine(teste);
                
            }
        }
    }
}
