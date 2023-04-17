using System.Reflection.Metadata.Ecma335;
using static System.Net.Mime.MediaTypeNames;

namespace _07_Encapsulamento._02_Propriedades_de_acesso._02_Set
{
    class Dirigir
    {

        private int Idade ;

        public int IdadeAcessar
        {
            get
            {
                return Idade;
            }
            set
            {
                if (value >= 18)
                {
                    Console.WriteLine("Pode dirigir");
                }
                else
                {
                    Console.WriteLine("Não pode dirigir");
                }
            }
        }
    }
}
