namespace _01_variaveis_e_tipos_de_dados._02_tipos_de_dados_personalizados
{
   
    public class tipo_classeCar   //Classes: As classes são o bloco básico de construção de tipos em C#. Você pode criar suas próprias classes para definir tipos de dados personalizados com atributos e métodos.
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public double Price { get; set; }

        public void StartEngine()
        {
            // Lógica para iniciar o motor do carro
        }

    }
}
