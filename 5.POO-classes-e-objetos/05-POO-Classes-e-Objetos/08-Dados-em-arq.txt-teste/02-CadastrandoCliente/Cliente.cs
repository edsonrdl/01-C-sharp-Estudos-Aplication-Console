using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;

namespace _05_POO_Classes_e_Objetos._08_Dados_em_arq.txt_teste._02_CadastrandoCliente
{
    public class Cliente
    {
        public string Nome;
        public string Sobrenome;
        public string Cpf;

        public Cliente()
        {
        }
        public Cliente(string nome, string sobrenome, string cpf)
        {
            Nome=nome;
            Sobrenome  =sobrenome;
            Cpf=cpf;
        }

        public void Gravar()
        {
            var clientes = Cliente.LerClientes();
            clientes.Add(this);
            if (File.Exists(CaminhoBaseClientes()))
            {
                StreamWriter r = new StreamWriter(CaminhoBaseClientes());
               //  string conteudo = "Nome,Sobrenome,Cpf.\n";
                // string conteudo = "Nome,Sobrenome,Cpf.";
                r.WriteLine("Nome,Sobrenome,Cpf.");
                foreach (Cliente Client in clientes)
                {
                  //  conteudo += Client.Nome + "," + Client.Sobrenome + "," + Client.Cpf + "\n";
                    var linha = Client.Nome + "," + Client.Sobrenome + "," + Client.Cpf;
                    r.WriteLine(linha);
                }
              //  File.WriteAllText(CaminhoBaseClientes(), conteudo);
                r.Close();
            }

        }
     
        private static string CaminhoBaseClientes()
        {
            return ConfigurationManager.AppSettings["DatabaseArquivoCadastro"];
        }

        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();
            if (File.Exists(CaminhoBaseClientes()))
            {
                using (StreamReader arquivo = File.OpenText(CaminhoBaseClientes()))
                {

                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        {
                            var ClienteArquivo = linha.Split(',');
                            //por Construtor vazio
                            // var cliente = new Cliente();
                            //cliente.Nome=ClienteArquivo[0];
                            //cliente.Sobrenome=ClienteArquivo[1];
                            //cliente.Cpf=ClienteArquivo[2];

                            // por bloco
                            // var cliente = new Cliente{Nome=ClienteArquivo[0],Sobrenome=ClienteArquivo[1],Cpf=ClienteArquivo[2]};
                            //Por parãmetros  do construtor
                            var cliente = new Cliente(ClienteArquivo[0], ClienteArquivo[1], ClienteArquivo[2]);
                            clientes.Add(cliente);
                        }
                    }
                }
            }
            return clientes;
        }
        public void Consultar()
        {
            var Clientes = Cliente.LerClientes();

            foreach (var v in Clientes)
            {
                Console.WriteLine($"Nome:{v.Nome}\nSobrenome:{v.Sobrenome}\nCPF:{v.Cpf}");

            }
        }

        public void CriarCliente()
        {
            var Cliente1 = new Cliente("Maria", "Souza", "222.222.222-22");
            Cliente1.Gravar();


            var Cliente2 = new Cliente("Pedro", "Ferreira", "333.333.333-33");
            Cliente2.Gravar();


            var Cliente3 = new Cliente("Luciana", "Gomes", "444.444.444-44");
            Cliente3.Gravar();

            var Clientes = Cliente.LerClientes();

            foreach (Cliente Client in Clientes)
            {
                Console.WriteLine($"Nome:{Client.Nome}\nSobrenome:{Client.Sobrenome}\nCPF:{Client.Cpf}");
            }
        }


    }
   
}
