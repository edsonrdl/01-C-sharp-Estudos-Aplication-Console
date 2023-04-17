namespace _03_Array._03_metodos_array
{
    public class _02_metodo_copy
    {
        public void exibirResultado()
        {
 
            int[] numeros = { 1, 2, 3, 4, 5 };

            // Cria uma matriz de destino vazia com o mesmo tamanho da matriz de origem
            int[] numerosCopia = new int[numeros.Length];

            // Copia os elementos da matriz de origem para a matriz de destino
            Array.Copy(numeros, 0, numerosCopia, 0, numeros.Length);
            foreach (int n in numerosCopia){
               Console.WriteLine(n);
        }
        }
    }
}
