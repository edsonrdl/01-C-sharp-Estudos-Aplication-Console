using System.Reflection;

namespace _05_Herança._02_Heranca_de_construtores
{
    public  class Veiculo
    {
        // Atributos
        private string Modelo;
        private string Marca;
        public int Ano;
        private float Preco;
        private int Rodas;
        public bool Ligado;
        
        public Veiculo(string modelo, string marca, int ano, float preco,int rodas)
        {
            Modelo = modelo;
            Marca = marca;
            Ano = ano;
            Preco = preco;
            Rodas = rodas;
        }

        // Métodos
        public virtual void Ligar()
        {
            Ligado = true;
        }
        public virtual void Desligar()
        {
            Ligado = false;
        }
        public virtual void MostrarInformacoes()
        {
            Console.WriteLine($"Modelo: {Modelo}\nMarca: {Marca}\nAno: {Ano}\nPreço: {Preco:C}");
        }
    }

    //class Carro devira da class veiculo que é a base
    public class Carro : Veiculo
    {
        public Carro(string modelo, string marca, int ano, float preco, int rodas) : base(modelo, marca, ano, preco, rodas)
        {
        }
        public override void MostrarInformacoes()
        {
            Console.WriteLine($"Modelo carro:");
            base.MostrarInformacoes();
        }
    }
    //class Carro devira da class veiculo que é a base
    public class Caminhao : Veiculo
    {
        public Caminhao(string modelo, string marca, int ano, float preco) : base(modelo, marca, ano, preco, 16)
        {
        }

        public override void MostrarInformacoes()
        {
            Console.WriteLine("Modelo Caminhão");
            base.MostrarInformacoes();
        }
    }
}
