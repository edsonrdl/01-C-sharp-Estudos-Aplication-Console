﻿namespace _05_POO_Classes_e_Objetos._03_Metodos._03_Sobrecarga_de_metodos
{
      class Somar
      {

          public  int SomarInt(params int[]Num)
          {
            int  somar = 0;
              for (int i = 0; i <Num.Length; i++)
              {
                  somar += Num[i];
              }
              return somar;
          }

    }

}
