namespace _05_POO_Classes_e_Objetos._05_Construtores._02_sobrecarga_construtores
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
