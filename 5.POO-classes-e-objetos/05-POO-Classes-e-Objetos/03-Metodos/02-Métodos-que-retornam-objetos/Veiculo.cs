using System;

namespace _05_POO_Classes_e_Objetos._03_Metodos._02_Métodos_que_retornam_objetos
{
      class Veiculo
    {
        private  string Modelo;
        private int QtdVeiculo;
        public Veiculo(string modelo)
        {
           Modelo=modelo;
           QtdVeiculo = 0;


        }

        public Carro CriarCarro( )
        {
            QtdVeiculo++;
            return new Carro(QtdVeiculo, Modelo);
        }
    }

      class Carro
      {
          private int QtdVeiculo;
          private string MeuModelo;
        public Carro(int qtdVeiculo, string meuModelo)
        {
           QtdVeiculo = qtdVeiculo;
           MeuModelo = meuModelo;

           Console.WriteLine("Carro criado:{0} - {1}",QtdVeiculo,MeuModelo);
          }
      }
}
