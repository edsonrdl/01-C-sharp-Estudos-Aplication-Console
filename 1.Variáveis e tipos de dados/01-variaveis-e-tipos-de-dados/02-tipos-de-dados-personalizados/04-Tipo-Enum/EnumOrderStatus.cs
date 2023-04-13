using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_variaveis_e_tipos_de_dados._02_tipos_de_dados_personalizados
{
    public class EnumOrderStatus
    {
        enum OrderStatus1
        {
            New,
            Processing,
            Shipped,
            Delivered
        }
        //Enum para declarar uma variável e atribuir um de seus valores a ela. Por exemplo:
        enum DiasDaSemana
        {
            Domingo=1,
            Segunda=2,
            Terca=3,
            Quarta=4,
            Quinta=5,
            Sexta=6,
            Sábado=7
        }

        public void exibirResultado()
        {
            OrderStatus1 exibirEnum = OrderStatus1.New;
            Console.WriteLine($"Utilizando o enum e pegando seu identificador OrderStatus.New exibindo o : {exibirEnum}");

            //ou pelo indice

            OrderStatus1 exibirEnumIndic = (OrderStatus1)3;
            Console.WriteLine($"Utilizando indice :{exibirEnumIndic}");

            //Enum com atribuição
            DiasDaSemana hoje = DiasDaSemana.Segunda;
            Console.WriteLine($"Hoje é {hoje}");

            //Ou pelo seu valor atribuido 


            DiasDaSemana hojeAtribuicao = (DiasDaSemana)1;
            Console.WriteLine($"Utilizando a atribuição, hoje é  :{hojeAtribuicao}");
        }
           
    
    }
}
