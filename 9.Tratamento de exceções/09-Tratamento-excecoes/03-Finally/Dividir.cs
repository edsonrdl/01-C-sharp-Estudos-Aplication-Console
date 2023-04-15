namespace _09_Tratamento_excecoes._03_Finaly
{
    public class Dividir
    {
        public int res;
        public int num1;
        public int num2;

        public void Div()
        {
            num1 = 3;
            num2 = 0;
            try
            {
                res = num1 / num2;
            }
            catch (Exception e)
            {
                Console.WriteLine("Erro:{0}", e.Message);
                Console.WriteLine("Erro:{0}", e);
                Console.WriteLine("Erro:{0}", e.GetType());
            }
            finally
            {
                Console.WriteLine("A divisão foi realizada com sucesso ou ocorreu um erro.Fim do processo!");
            }
        }
    }
    //Nesse exemplo, o bloco finally é utilizado para imprimir uma mensagem após o try e o catch,
    //Independentemente de ocorrer ou não uma exceção. Dessa forma, sempre que o método "Div" for chamado,
    //A mensagem será exibida, indicando que a divisão foi realizada com sucesso ou ocorreu um erro.
}
