using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Estruturas_de_controle_de_fluxo._01_Condicionais
{

    public class _01_Condicional_if
    {
        public void exibirResultado()
        {
            //if -->se
            int nota1 = 80;
            string result1 = "Reprovado";

            if (nota1 >= 60)
            {
                result1 = "Aprovado";

            }
            Console.WriteLine($"Resultado da nota1 é : {result1}"); 

            //utilizando if e else  -->Se Senão 
            int nota2 = 50;
            string result2 = "";

            if (nota2 >= 60)
            {
                result2 = "Aprovado";
            }
            else
            {
                result2 = "Reprovado";
            }
            Console.WriteLine($"Resultado da nota2 é : {result2}");

            //Utilizando if alinhados 
            int nota3 = 90;
            string result3 = "";

            if (nota3 >= 60)
            {
                if(nota3 >= 90)
                {
                    result3 = "Parabêns,você foi aprovado com uma ótima nota";
                }
                else
                {
                    result3 = "Você foi aprovado";
                }
            }
            else
            {
                if (nota3>=40)
                {
                    result3 = "Recuperaçaão";
                }
                else
                {
                    result3 = "Reprovado";
                }
            }
            Console.WriteLine($"Resultado da nota3 é : {result3}");



        }
    }
}
