namespace _08_Interfaces._03_Uso_de_Multiplas_interface
{
    public interface  IPessoa
    {

        void Nome();
        void Idade();
     
    }
    public interface IEndereco
    {
        void Logradouro();
        void Numero();
        void Cidade();
        void Estado();
    }
   
    public class Pessoa : IPessoa, IEndereco
    {
        public string nome;
        public int idade;
        public string logradouro;
        public string numero;
        public string cidade;
        public string estado;
      
        public Pessoa(string nome, int idade, string logradouro, string numero, string cidade, string estado)
        {
            this.nome = nome;
            this.idade = idade;
            this.logradouro = logradouro;
            this.numero = numero;
            this.cidade = cidade;
            this.estado = estado;
        }

        public void Nome()
        {
            Console.WriteLine(this.nome = "João");
        }

        public void Idade()
        {
            Console.WriteLine(this.idade = 40);
        }
        public void Logradouro()
        { 
            Console.WriteLine(this.logradouro = "Rua A");
        }
        public void Numero()
        {
            Console.WriteLine(this.numero = "123");
           
        }
        public void Cidade()
        {
            Console.WriteLine(this.cidade = "São Paulo");
            
        }
        public void Estado()
        {
            Console.Write(this.cidade = "São Paulo");

        }

    }

}
