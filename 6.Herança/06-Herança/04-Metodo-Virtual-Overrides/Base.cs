namespace _05_Herança._04_Metodo_Virtual_Overrides
{
    //métodos em classes derivadas que tem o mesmo nome dos métodos da classe base
    //entao usa p termo virtual no método base e no derivado usa o override
    public class Base
    {
        public void ExibirResultado()
        {
            Console.WriteLine("Base");
        }

       virtual public void Infor()
        {
            Console.WriteLine("Método Virtual Base");

        }
    }
    public class Devirada1 : Base
    {
        public void ExibirResultado()
        {
            Console.WriteLine("Derivada 1");
            base.ExibirResultado();
        }
     override  public void Infor()
        {
            Console.WriteLine("Método infor() de Derivada 1");

        }
    }
    public class Devirada2 : Devirada1 

    {
        public void ExibirResultado()
        {
            Console.WriteLine("Derivada 1");
            base.ExibirResultado();
        }
        override public void Infor()
        {
            Console.WriteLine("Método infor() de Derivada 2");
        }
    }
}
