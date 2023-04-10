namespace _03_Array._03_metodos_array
{
    public class _03_metodo_copyTo
    {
        public void exibirResultado()
        {
               // Cria uma lista de inteiros
        List<int> numeros = new List<int>() { 1, 2, 3, 4, 5 };

        // Cria uma matriz de destino vazia com o mesmo tamanho da lista de origem
        int[] numerosCopia = new int[numeros.Count];

        // Copia os elementos da lista de origem para a matriz de destino
        numeros.CopyTo(numerosCopia, 0);

        // Imprime os elementos da matriz de destino
        Console.WriteLine("Elementos da matriz de destino:");
        foreach (int numero in numerosCopia)
        {
            Console.Write("{0} ", numero);
        }
        }
        //O método CopyTo é usado para copiar os elementos da lista de inteiros numeros para a matriz numerosCopia.
        //O método é chamado passando como parâmetros a matriz de destino(numerosCopia) e a posição inicial na matriz de destino(0).
        // Depois que a cópia é concluída, os elementos da matriz de destino são impressos na tela usando um loop foreach.
        //Este exemplo é simples, mas a versatilidade do método CopyTo em C# é muito útil em diversas situações.
    }
}
