namespace _01_variaveis_e_tipos_de_dados;

public class conversão_de_tipos {
    public void exibirResultado()
    {
        float n1 = 10.5f;  //    tipo1 variavel=valor -->tipo2  variavelNova=(tipo)variavel     variavelNova=novoValor
        int n2=(int)n1;//tipo cast   vai mudar float 10.5 para valor inteiro int 10
        Console.WriteLine(n2);

        string s1 = "123";
        int i1 = Convert.ToInt32(s1);//Neste exemplo, a variável s contém uma string que representa um valor inteiro. Para converter essa string em um valor int, usamos o método Convert.ToInt32() da classe Convert.O resultado é armazenado na variável i1.
        Console.WriteLine(s1);

        string s2 = "3.14";
        double i2 = double.Parse(s2); //Neste exemplo, a variável s contém uma string que representa um valor numérico. Para converter essa string em um valor double, usamos o método double.Parse(). O resultado é armazenado na variável i2.
        Console.WriteLine(s2);


        string s3 = "3.14";
        double d;
        if (double.TryParse(s3, out d))
        {
            Console.WriteLine("Conversão bem sucedida. d = " + d);
        }
        else
        {
            Console.WriteLine("Conversão falhou.");
        }
        string s4 = "3.14";
        int b;
        if (int.TryParse(s4, out b))
        {
            Console.WriteLine("Conversão bem sucedida. d = " + b);
        }
        else
        {
            Console.WriteLine("Conversão falhou.");
        }


    }

}