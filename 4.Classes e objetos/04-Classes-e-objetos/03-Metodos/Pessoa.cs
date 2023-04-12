namespace _04_Classes_e_objetos._03_Metodos
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
