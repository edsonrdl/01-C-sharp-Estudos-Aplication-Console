namespace _07_Encapsulamento._01_Modificadores_de_acesso._02_Modificador_Private
{
     class Cliente
    {
        // Atributos utilizando private podem ser acessados apenas dentro da própria class 
        private string Nome;

        private string Sobrenome;

        private string Endereco;

        private string Telefone;
       
       public Cliente(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        //public ClientePrivate()
        //{
        //    Endereco = "Rua dos Sonhos, 123 - Bairro Felicidade, Cidade dos Sonhos";
        //    Telefone = "11291793984";
        //}
        public string GetNome()
        {
            return Nome;
        }
        public string GetSobrenome()
        {
            return Sobrenome;
        }
        public string GetEndereco()
        {
            return Endereco;
        }
        public string GetTelefone()
        {
            return Telefone;
        }
        public string SetNome(string nome)
        {
            return Nome = nome;
        }
        public string SetSobrenome(string sobrenome)
        {
            return Sobrenome = sobrenome;
        }

     
        public void InforCliente()
        {
            Console.WriteLine("Exibir informações  {0} {1} {2} {3}",GetNome(),GetSobrenome(), GetEndereco(),GetTelefone());
        }
    
    }
    //A palavra-chave private em C# é outro modificador de acesso que indica que um membro (método, propriedade, campo ou evento) de uma classe
    //Só é acessível dentro da própria classe. Ou seja, membros declarados como private não podem ser acessados por outras classes ou objetos.
    //Só vai poder acessar usando os métodos de acesso.
}
