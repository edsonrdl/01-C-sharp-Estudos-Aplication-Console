using System.Drawing;

namespace _01_variaveis_e_tipos_de_dados._02_tipos_de_dados_personalizados;

public struct Point {
    public int X ;
    public int Y ;
    public int Z ;

    public Point(int x, int y, int z)
    {
        X=x;
        Y=y;
        Z=z;
    }
}

class MyPoint
{
    public void CriarPoint()
    {
        var pointTeste1 = new Point[2];//Criar um Array de struct
        //Passar o valor para o primeiro 
        Console.WriteLine(pointTeste1[0].X=1);
        Console.WriteLine(pointTeste1[0].Y=2);
        Console.WriteLine(pointTeste1[0].Z=3);
        //Passar o valor para o segundo
        Console.WriteLine(pointTeste1[1].X = 1);
        Console.WriteLine(pointTeste1[1].Y = 2);
        Console.WriteLine(pointTeste1[1].Z = 3);
    }
}
