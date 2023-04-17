using System;

namespace _05_POO_Classes_e_Objetos._04_Parametros._02_Metodos_de_parametros_por_referencia
{
    public class Dobrar
    {
        public void Value()
        {
            int num = 10;
            DobrarValue(ref num);
            Console.WriteLine($"Por referênmcia :{num}");
        }
        public void DobrarValue(ref int valor)
        {
            Console.WriteLine(valor *= 2);
           
        }

    }
    //Quando um parâmetro é passado por referência usando a palavra-chave "ref".
    //O método chamado pode alterar o valor da variável original que foi passada como argumento.
    //Por outro lado, quando um parâmetro é passado por valor.
    //Uma cópia da variável original é criada e usada dentro do método chamado.
    //E qualquer alteração feita no valor do parâmetro dentro do método não afeta a variável original.
    //A palavra-chave "ref" é usada ao chamar o método "DobrarValue", o que significa que a variável original "num" é passada por referência
    //E qualquer alteração feita dentro do método afetará diretamente o valor de "num" fora do método.
}
