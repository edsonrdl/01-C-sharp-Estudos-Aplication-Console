namespace _07_Encapsulamento._01_Modificadores_de_acesso._06_Modificador_Static
{
     static public class Cliente6  
    {
        static  string Nome;
        static string Sobrenome;


        static public void CriarCliente(string nome,string sobrenome)
        {
            Nome =nome;
            Sobrenome =sobrenome;
        }
        static public void InforCliente()
        {
           Console.WriteLine("Cliente {1} {0} :", Nome,Sobrenome);
        }

    }
     //Static não permite criar instância
}
