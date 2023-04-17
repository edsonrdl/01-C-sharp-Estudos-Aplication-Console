using System;
using System.Configuration;
using System.IO;

namespace _05_POO_Classes_e_Objetos._08_Dados_em_arq.txt_teste._01_LendoArquivoTXT
{
    public class LerArquivo
    {
        private string CaminhoArquivo()
        {
            return ConfigurationManager.AppSettings["NomeClientes"];
        }
        public void ProcessarArquivo(int NomeArquivo)
        {
            string arquivoComCaminho = CaminhoArquivo() + NomeArquivo + ".txt";
            if (File.Exists(arquivoComCaminho))
            {
                using (StreamReader arquivo = File.OpenText(arquivoComCaminho))
                {
                    string linha;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        Console.WriteLine(linha);
                    }
                }
            }
            string arquivoComCaminho2 = CaminhoArquivo() + (NomeArquivo + 1) + ".txt";
            if (File.Exists(arquivoComCaminho2))
            {
                ProcessarArquivo(NomeArquivo +1); 
            }

        }
       

        public void lerArquivo()
        {
            ProcessarArquivo(1);

        }
      
    }
}
