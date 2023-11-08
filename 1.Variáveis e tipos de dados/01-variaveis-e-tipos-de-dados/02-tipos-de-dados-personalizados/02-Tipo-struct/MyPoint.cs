namespace _01_variaveis_e_tipos_de_dados._02_tipos_de_dados_personalizados._02_Tipo_struct;

class MyPoint
{
    public void CriarPoint()
    {
        var pointTeste1 = new Point[2];//Criar um Array de struct
        //Passar o valor para o primeiro 
        Console.WriteLine($"Primeira {pointTeste1[0].X = 1}");
        Console.WriteLine(pointTeste1[0].Y=2);
        Console.WriteLine(pointTeste1[0].Z=3);
        //Passar o valor para o segundo
        Console.WriteLine(pointTeste1[1].X = 1);
        Console.WriteLine(pointTeste1[1].Y = 2);
        Console.WriteLine(pointTeste1[1].Z = 3);
    }
}