namespace _03_Array._01_declaracao_array
{
    public class _01_declaracao_array   
    {
        public void exibirResultado()
        {
            //Criando array 1
            //Tipo[] variavel=new tipo[Qunatidade de indices]
            // variavel[indice] = "valor";
            string[] n1 = new String[5];
            n1[0] = "Luffy";
            n1[1] = "Robin";
            n1[2] = "Usopp";
            n1[3] = "Zoro";
            n1[4] = "Sanji";

            for (int i = 0; i < n1.Length; i++)
            {
                Console.WriteLine(n1[i]);
            }

            //Criando arra 2
            //Tipo[] variavel=new tipo[Qunatidade de indices] {valor1 ,valor2 ,valor3 ...};
            int[] n2 = new int[5] { 2, 3, 5, 6, 3 };
            Console.WriteLine(n2[3]);

            //Criando arra 3
            //Tipo[] variavel={valor1 ,valor2 ,valor3 ...};
            int[] num = { 23, 45, 23, 34 };
            Console.WriteLine(num[0]);
        }
    }
}
