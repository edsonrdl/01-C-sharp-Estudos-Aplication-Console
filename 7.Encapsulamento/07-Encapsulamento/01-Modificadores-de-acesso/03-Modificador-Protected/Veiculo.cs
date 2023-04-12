namespace _07_Encapsulamento._01_Modificadores_de_acesso._03_Modificador_Protected
{
    public  class Veiculo
    {
        // Atributos utilizando protected ,podem ser acessados dentro da class base e derivadas
        private string Modelo;
        private string Marca;
        protected int VelocidadeMax;
        public int Ano;
        private float Preco;
        public int Rodas;
        protected bool Ligado;

        public Veiculo(string modelo, string marca,int velocidadeMax, int ano, float preco, int rodas ,bool ligado
        )
        {
            Modelo = modelo;
            Marca = marca;
            VelocidadeMax= velocidadeMax;
            Ano = ano;
            Preco = preco;
            Rodas = rodas;
            Ligado = ligado;


        }

        // Métodos
        public  string Ligar()
        {
            return (Ligado ? "Está Sim" : "Não Está");
        }
      
        public virtual void MostrarInformacoes()
        {
            Console.WriteLine($" Modelo:{Modelo}\n Marca:{Marca}\n Ano:{Ano}\n Preço:{Preco:C}");
        }
    }

    //class Carro devira da class veiculo que é a base
    public class Carro : Veiculo
    {
        public Carro(string modelo, string marca,int velocidadeMax, int ano, float preco,bool ligado) : base(modelo, marca,velocidadeMax ,ano, preco, 4,ligado)
        {
        }
        public override void MostrarInformacoes()
        {
            base.MostrarInformacoes();
        }
    }
    //class Caminhão devira da class veiculo que é a base
    public class Caminhao : Veiculo
    {
        public Caminhao(string modelo, string marca, int velocidadeMax, int ano, float preco, bool ligado) : base(modelo, marca, velocidadeMax, ano, preco, 12,ligado)
        {
        }

        public override void MostrarInformacoes()
        {
            Console.WriteLine("Modelo Caminhão");
            base.MostrarInformacoes();
        }
    }
}
