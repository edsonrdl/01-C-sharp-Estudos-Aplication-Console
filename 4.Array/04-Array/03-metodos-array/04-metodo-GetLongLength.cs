namespace _03_Array._03_metodos_array
{
    public class _04_metodo_GetLongLength
    {
        public void exibirResultado()
        {
            // Cria uma matriz com duas dimensões
            int[,] matriz = new int[3, 4];

            // Imprime o comprimento de cada dimensão
            Console.WriteLine("Comprimento da primeira dimensão: {0}", matriz.GetLongLength(0));
            Console.WriteLine("Comprimento da segunda dimensão: {0}", matriz.GetLongLength(1));
        }
    }
}
