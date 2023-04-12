namespace _07_Encapsulamento._01_Modificadores_de_acesso._01_Public
{
    public class Cliente
    {
        public string Nome;

        public string Sobrenome;

        public string Endereco;

        public string Telefone;


        public Cliente(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        public  Cliente()
        {
            Endereco = "Qualquer lugar";
            Telefone = "11291793984" ;
        }

       

        public void InforClientePublic()
        {
            Console.WriteLine("Exibir Informações de {0} e {1} ", Endereco, Telefone);
        }
        public string CriarCliente()
        {
            return Nome + " " + Sobrenome;

        }
     
    }
    //  A palavra-chave public em C# é um modificador de acesso
    // Que indica que um membro (método, propriedade, campo ou evento) de uma classe é acessível de fora da classe
    // Pode ser utilizado por outros objetos e classes.
    //Pode ser acesssado ou criado pela função InforClientePublic e CriarCliente respectivamente
}
