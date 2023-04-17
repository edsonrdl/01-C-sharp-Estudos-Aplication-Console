using System;

namespace _05_POO_Classes_e_Objetos._04_Parametros._04_Metodos_de_parametros_params
{
    internal class Somar
    {
        public void exibirResultado()
        {
            soma();
        }

        public void soma(params int[]n)  //pode entrar com ou sem parametro sem precisar usar como argumento 
        {
            int res = 0;
            if (n.Length < 1)
            {
                Console.WriteLine("Não existem valores para serem somados");
            }
            else
           if(n.Length<2) {
               Console.WriteLine("Valores insuficientes oara soma :{0}", n[0]);
                
            }
           else
           {
               for (int i = 0; i < n.Length; i++)
               {
                   res += n[i];
               }
               Console.WriteLine("A soma dos valores é: {0}", res);
            }
         
        }
    }
}
