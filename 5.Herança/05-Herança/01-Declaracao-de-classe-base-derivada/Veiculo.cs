namespace _05_Herança._01_Declaracao_de_classe_base_derivada
{
     public class Veiculo
    {
        // Atributos
        public string Modelo;
        public string Marca;
        public int Ano;
        public float Preco;
        public bool Ligado;

        // Métodos
        public void Ligar()
        {
            Ligado=true;
        }

        public void Desligado()
        {
            Ligado = false;

        }

        public void MostrarInformacoes()
        {
            Console.WriteLine($"Modelo: {Modelo}\nMarca: {Marca}\nAno: {Ano}\nPreço: {Preco:C}");
        }

       
    }

     //class Carro devira da class veiculo que é a base
    public class Carro : Veiculo 
     {
         public void CarroTeste()
         {
             Ligado = true;
         }

     }
}
