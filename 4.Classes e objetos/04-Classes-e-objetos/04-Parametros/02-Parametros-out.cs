namespace _04_Classes_e_objetos._04_Parametros
{
    public class _02_Parametros_out
    {
        public void exibirResultado()
        {
            int div, divsor, quoc, rest;
            div = 4;
            divsor = 2;
            quoc= dividir(div, divsor,out rest);
            Console.WriteLine("{0}/{1}:quociente={2} e resto={3}", div,divsor,quoc,rest);
                    }

        public int dividir(int dividendo,int divisor, out int resto)
        {
            int quociente;
            quociente = dividendo / divisor;
            resto = dividendo % divisor;
            return quociente;
        }

    }
}
