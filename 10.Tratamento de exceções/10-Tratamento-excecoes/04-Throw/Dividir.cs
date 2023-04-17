namespace _09_Tratamento_excecoes._04_Throw
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
                if (num2 == 0)
                {
                    throw new DivideByZeroException("Divisão por zero!");
                }
                res = num1 / num2;
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("Erro: {0}", e.Message);
            }
            finally
            {
                Console.WriteLine("A divisão foi realizada com sucesso ou ocorreu um erro.\nFim do processo!");
            }
        }
    }
    //Nesse exemplo, o bloco try verifica se o num2 é igual a zero e, se for, gera uma exceção DivideByZeroException com a mensagem "Divisão por zero!" utilizando o throw.
    //Em seguida, o bloco catch é executado para tratar a exceção gerada e imprimir a mensagem de erro na tela. Por fim,
    //O bloco finally é executado para imprimir uma mensagem indicando que a divisão foi realizada com sucesso ou ocorreu um erro.

}
