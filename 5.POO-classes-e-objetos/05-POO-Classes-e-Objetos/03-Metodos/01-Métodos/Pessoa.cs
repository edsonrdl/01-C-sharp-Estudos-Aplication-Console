namespace _05_POO_Classes_e_Objetos._03_Metodos._01_Métodos
{
      class Pessoa
    {
        string Nome;
        string Sobrenome;
        string Endereco;
        string Telefone;
        public string NomeSobrenome()
        {
            return Nome + " " + Sobrenome;
        }
    }
    // NomeSobrenome é um método da class Pessoa que retorna as propriedades Nome e Sobrenome
}
