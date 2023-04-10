namespace _03_Array._02_array_utilizando_matrizes
{
    public class _01_array_adicionando_matrizes
    {
        public void exibirResultado()
        {
            //Declaração 
            //tipo[,] variavel=new tipo[linhas,colunas];
            // variavel[linha,coluna] = valor;
            int[,] n1 = new int[3, 5];
            n1[0,0] = 1;
            n1[1,1] = 23;
            n1[2,2] = 2;
            n1[3,3] = 17;

            Console.WriteLine(n1[0,0]);

            //ou 
            int[,] n2= new int[2, 2]{{21,2},{43,34}};

            Console.WriteLine(n2[0, 0]);

        }
    }
}
