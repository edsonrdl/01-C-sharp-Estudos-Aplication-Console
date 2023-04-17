using System;

namespace _04_Classes_e_objetos._04_Parametros._01_Metodos_de_parametros_por_valor
{
    public class Dobrar
    {
        public void Value()
        {
            int num = 10;
            DobrarValue(num);
            Console.WriteLine($"Por valor:{num}");

        }
        public void DobrarValue( int valor)
        {
            Console.WriteLine(valor *= 2);
           
        }
    }
    //O valor de "num" é passado por valor para o método "DobrarValue", o que significa que o valor original de "num" não é alterado após a execução do método.
}
