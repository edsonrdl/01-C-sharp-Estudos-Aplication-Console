namespace _05_Herança._03_Ordem_de_execução
{
    public class Base
    {
        public void ExibiResultado()
        {
            Console.WriteLine("Base");
        }
    }

    public class Devirada1 : Base
    {
        public void ExibiResultado()
        {
            Console.WriteLine("Derivada 1");
        }
    }
    public class Devirada2 : Devirada1
    {
        public void ExibiResultado()
        {
            Console.WriteLine("Derivada 2");
        }
    }
}
