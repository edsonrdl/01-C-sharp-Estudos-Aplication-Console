namespace _08_Interfaces._02_Implementando_interface
{
    public interface  IPessoa
    {
         
        string Nome { get; set; }

    }
   
    public class Pessoa : IPessoa
    {
        public string Nome
        {
            get
            {
                return Nome;
            }
            set
            {
                if (value=="Luffy")
                {
                    Console.WriteLine("Capitão");
                }
                else
                { Console.WriteLine("Erro");
                }
            }
        }
        
    }
}
