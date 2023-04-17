namespace _05_POO_Classes_e_Objetos._07_Utilizando_this
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
