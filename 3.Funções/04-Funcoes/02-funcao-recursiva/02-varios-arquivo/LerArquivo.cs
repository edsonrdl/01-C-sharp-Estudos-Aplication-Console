﻿namespace _04_Funcoes._02_funcao_recursiva._02_varios_arquivo
{
    public class LerArquivo
    {
        public void ProcessarArquivo(int NomeArquivo)
        {
            string arquivoComCaminho = "D:\\Edson\\Estudos\\Programação\\back-end\\C-sharp-estudos\\arquivos para testes\\arq" + NomeArquivo + ".txt";
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
            string arquivoComCaminho2 = "D:\\Edson\\Estudos\\Programação\\back-end\\C-sharp-estudos\\arquivos para testes\\arq" + (NomeArquivo + 1) + ".txt";
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
