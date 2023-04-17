﻿namespace _04_Funcoes._02_funcao_recursiva._01_Unico_arquivo
{
    public class LerArquivo
    {
        public void ProcessarArquivo(string Arquivo)
        {
            using (StreamReader arquivo = File.OpenText(Arquivo))
            {
                string linha;
                while ((linha = arquivo.ReadLine()) != null)
                {
                  Console.WriteLine(linha);  
                }
            }
        }

        public void lerArquivo()
        {
            ProcessarArquivo("C:\\Users\\edson\\Documents\\testes\\tripulacaoChapeuDepalha.txt");

        }
      
    }
}
