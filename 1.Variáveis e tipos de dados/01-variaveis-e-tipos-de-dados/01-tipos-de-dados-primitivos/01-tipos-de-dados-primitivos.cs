namespace _01_variaveis_e_tipos_de_dados
{
    public class _01_tipos_de_dados_primitivos
    {
        public string nome = "Monkey D. Luffy";//tipo de dado que representa uma sequência de caracteres (texto).

        public int anos = 19;//tipo de dado numérico inteiro que representa números inteiros
                             //.
        public double altura = 1.75;//tipo de dado numérico de ponto flutuante que representa números com casas decimais.

        public float temperatura = 26.5f;//tipo de dado numérico de ponto flutuante, porém, com precisão menor que o double.

        public bool estaChovendo = false;//tipo de dado booleano que representa os valores true ou false.

        public char letra = 'A';//tipo de dado que representa um caractere Unicode.

        public byte codigo = 65; //tipo de dado numérico inteiro não negativo, com valores na faixa de 0 a 255.

        public short distancia = 1500;//tipo de dado numérico inteiro que representa números inteiros menores que o tipo int.

        public long populacaoMundial = 7800000000; //tipo de dado numérico inteiro que representa números inteiros maiores que o tipo int.
        public void  exibirResultado()
        {
            Console.WriteLine($"Meu nome é {nome}"); 
            Console.WriteLine($"tenho {anos} anos");
            Console.WriteLine(altura);
            Console.WriteLine(temperatura);
            Console.WriteLine(estaChovendo);
            Console.WriteLine(letra);
            Console.WriteLine(codigo);
            Console.WriteLine(distancia);
            Console.WriteLine(populacaoMundial);
        }

    }

}
 





