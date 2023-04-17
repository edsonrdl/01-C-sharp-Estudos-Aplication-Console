namespace _03_Array._03_metodos_array
{
    public class _00_metodo_array
    {
        public void exibirResultado()
        {
            soma(2,4);
        }

        static void soma(int num1,int num2)
        {
            int result = num1 + num2;
            Console.WriteLine("A soma de {0} e {1} é :{2}",num1,num2,result);
        }
    }
}
