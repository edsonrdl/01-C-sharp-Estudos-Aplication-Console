namespace _04_Classes_e_objetos._04_Construtores
{
    public class Cliente
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public Cliente(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }

        public string NomeCompleto()
        {
            return Nome + " " + Sobrenome;
        }
    }
}
