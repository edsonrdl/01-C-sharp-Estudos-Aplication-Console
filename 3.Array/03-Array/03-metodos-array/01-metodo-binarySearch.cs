namespace _03_Array._03_metodos_array
{
    public class _01_metodo_binarySearch
    {
        public void exibirResultado()
        {
            int[] numeros = { 2, 4, 6, 8, 10 };

            // Pesquisa o valor 6 no array usando o método BinarySearch
            int indice = Array.BinarySearch(numeros, 6);


            // Verifica se o valor foi encontrado e imprime o índice correspondente
            if (indice >= 0)
            {
                Console.WriteLine("O valor 6 foi encontrado no índice {0}", indice);
            }
            else
            {
                Console.WriteLine("O valor 6 não foi encontrado");
            }
        }
    }
}
