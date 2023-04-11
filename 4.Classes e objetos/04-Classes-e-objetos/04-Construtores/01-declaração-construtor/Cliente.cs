namespace _04_Classes_e_objetos._04_Construtores
{
    public class Cliente
    {
        public string Nome;
        public string Sobrenome;

        public Cliente(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }


        public string exibirResultado()
        {
            return Nome + " " + Sobrenome;
        }
    }
}
