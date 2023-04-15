using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_LinkedList
{
     class Veiculo
    {
        public void LinkedListVeiculo()
        {
            LinkedList<string> veiculo=new LinkedList<string>();
            veiculo.AddFirst("Carro");
            veiculo.AddFirst("Avião");
            veiculo.AddFirst("Caminhão");
            veiculo.AddFirst("Motocicleta");
            foreach (string v in veiculo)
            {
                Console.WriteLine(v);
            }
        }
    }
}
