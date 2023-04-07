
using _01_variaveis_e_tipos_de_dados._02_tipos_de_dados_personalizados;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_variaveis_e_tipos_de_dados;

class Program
{
    static void Main(string[] args)
    {
        EnumOrderStatus minhaInstancia = new EnumOrderStatus();
        minhaInstancia.exibirResultado();
    }
}