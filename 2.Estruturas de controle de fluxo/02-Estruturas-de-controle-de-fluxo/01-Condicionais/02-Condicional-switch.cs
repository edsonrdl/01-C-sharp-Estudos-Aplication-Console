using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Estruturas_de_controle_de_fluxo._01_Condicionais
{
    public class _02_Condicional_switch
    {
        //    switch (expressão)
        //{
        //    case valor1:
        //    // código a ser executado se expressão for igual a valor1
        //    break;
        //    case valor2:
        //    // código a ser executado se expressão for igual a valor2
        //    break;
        //    // mais casos...
        //    default:
        //    // código a ser executado se expressão não corresponder a nenhum dos valores dos casos anteriores
        //    break;
        //}
        public void exibirResultado()
      
        {
            int dia = 3;
            string nomeDia;

            switch (dia)
            {
                case 1:
                    nomeDia = "Domingo";
                    break;
                case 2:
                    nomeDia = "Segunda-feira";
                    break;
                case 3:
                    nomeDia = "Terça-feira";
                    break;
                case 4:
                    nomeDia = "Quarta-feira";
                    break;
                case 5:
                    nomeDia = "Quinta-feira";
                    break;
                case 6:
                    nomeDia = "Sexta-feira";
                    break;
                case 7:
                    nomeDia = "Sábado";
                    break;
                default:
                    nomeDia = "Dia inválido";
                    break;
            }

            Console.WriteLine($" {dia}  {nomeDia}");

            string capitao = "Luffy";
            string nomeDoCapitao ;

            switch (capitao)
            {
                case "Zoro":
                    nomeDoCapitao = "É o capitão";
                    break;
                case "Name":
                    nomeDoCapitao = "É o capitão";
                    break;
                case "Brook":
                    nomeDoCapitao = "É o capitão";
                    break; 
                case "Sanji":
                    nomeDoCapitao = "É o capitão";
                    break;
                case "Luffy":
                    nomeDoCapitao = "É o capitão";
                    break;
                case "Usopp":
                    nomeDoCapitao = "É o capitão";
                    break;
                case "Franky":
                    nomeDoCapitao = "É o capitão";
                    break;
                case "Robin":
                    nomeDoCapitao = "É o capitão";
                    break;
                default:
                    nomeDoCapitao = "Não encontrou o  capitão";
                    break;

            }
            Console.WriteLine($" {capitao} {nomeDoCapitao}");
            {
                
            }

        }
    }
}
