namespace _05_POO_Classes_e_Objetos._05_Construtores._01_declaração_construtor
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
        public string ExibirResultado()
        {
            return Nome + " " + Sobrenome;
        }
    }
}
