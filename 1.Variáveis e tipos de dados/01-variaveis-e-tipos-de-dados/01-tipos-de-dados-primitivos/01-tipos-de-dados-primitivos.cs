using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_variaveis_e_tipos_de_dados
{
    public class _01_tipos_de_dados_primitivos
    {
        public string nome = "Monkey D. Luffy";//tipo de dado que representa uma sequência de caracteres (texto).
        public int anos = 19;//tipo de dado numérico inteiro que representa números inteiros.
        public double altura = 1.75;//tipo de dado numérico de ponto flutuante que representa números com casas decimais.
        public float temperatura = 26.5f;//tipo de dado numérico de ponto flutuante, porém, com precisão menor que o double.
        public bool estaChovendo = false;//tipo de dado booleano que representa os valores true ou false.
        public void  exibirVariavel()
        {
            Console.WriteLine($"Meu nome é {nome}"); 
            Console.WriteLine($"tenho {anos} anos");
        }

    }

}
 



//char: é um tipo de dado que representa um caractere Unicode. Exemplo: char letra = 'A';

//byte: é um tipo de dado numérico inteiro não negativo, com valores na faixa de 0 a 255. Exemplo: byte codigo = 65;

//short: é um tipo de dado numérico inteiro que representa números inteiros menores que o tipo int. Exemplo: short distancia = 1500;

//long: é um tipo de dado numérico inteiro que representa números inteiros maiores que o tipo int. Exemplo: long populacaoMundial = 7800000000;