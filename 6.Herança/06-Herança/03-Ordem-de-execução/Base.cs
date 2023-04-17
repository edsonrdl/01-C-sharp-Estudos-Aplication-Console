namespace _05_Herança._03_Ordem_de_execução
{
    public class Base
    {
        public void ExibirResultado()
        {
            Console.WriteLine("Base");
        }
    }

    public class Devirada1 : Base
    {
        public void ExibiResultado1()
        {
            Console.WriteLine("Derivada 1");
            base.ExibirResultado();
        }
    }
    public class Devirada2 : Devirada1
    {
        public void ExibirResultado()
        {
            Console.WriteLine("Derivada 2");
            base.ExibirResultado();
            

        }
    }
}
