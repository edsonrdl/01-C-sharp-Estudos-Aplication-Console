using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Classes_e_objetos
{
    public class Calcular
    {

        public int num1;
        public int num2;
        //ou não precisa usar o this
        public int Num3;
        public int Num4;


        public Calcular(int num1, int num2,int num3,int num4)
        { 
             this.num1 = num1;
             this.num2 = num2;
             //ou Não precisa usar o this
             Num3=num3;
             Num4=num4;
        }

        public int ExibirResultado()
        {
            return num1 + num2 + Num3 + Num4;
        }

    }
    
}
