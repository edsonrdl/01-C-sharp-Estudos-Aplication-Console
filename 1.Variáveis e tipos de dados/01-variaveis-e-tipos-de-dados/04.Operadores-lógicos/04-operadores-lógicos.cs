using System.Security.Cryptography.X509Certificates;

namespace _04.Operadores_lógicos
{
    public class _04_operadores_lógicos
    {
        public void exibirResultado()
        {
            bool  menor= 5 < 10;
            bool  maior= 5 > 10;
            bool res=(5>3)|(5>2);

            Console.WriteLine(menor);
            Console.WriteLine(maior);
            Console.WriteLine(maior);
        }
    }
}
