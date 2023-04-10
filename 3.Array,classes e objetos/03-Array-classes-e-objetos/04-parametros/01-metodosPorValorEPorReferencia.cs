namespace _03_Array._04_parametros
{
    public class _01_metodosPorValorEPorReferencia
    {
        public void exibirResultado()
        {
            int num1 = 10;
            dobrarPorvalor(num1);
            Console.WriteLine($"Por valor{num1}");
            
            int num2 = 10;
            dobrarPorReferencia(ref num2);
            Console.WriteLine($"Por referênmcia {num2}");  
            
            
        }

        public void dobrarPorvalor( int valor)
        {
            valor*= 2;
        }  
        public void dobrarPorReferencia(ref int valor)
        {
            valor*= 2;
        }

    }
}
