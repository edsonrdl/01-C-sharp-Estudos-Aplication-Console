namespace _09_Tratamento_excecoes._02_Catch
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
                Console.WriteLine("Erro:{0}",e.Message);
                Console.WriteLine("Erro:{0}", e);
                Console.WriteLine("Erro:{0}", e.GetType());
            }
        }
    }

   // O bloco try em C# é utilizado para envolver um código que pode gerar exceções (erros) durante a sua execução.
   // O objetivo é tentar executar o código dentro do try
   // E se ocorrer alguma exceção, o fluxo do programa é transferido para um bloco catch que pode tratar a exceção.
}