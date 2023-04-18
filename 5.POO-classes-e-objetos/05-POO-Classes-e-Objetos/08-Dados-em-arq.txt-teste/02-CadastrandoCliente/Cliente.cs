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

        public  void GravarClienteDatabase()
        {
            var clientes = Cliente.LerClientes();
            clientes.Add(this);
            if (File.Exists(ArquivoDatabaseClientes()))
            {
                StreamWriter r = new StreamWriter(ArquivoDatabaseClientes());
               //  string conteudo = "Nome,Sobrenome,Cpf.\n";
                // string conteudo = "Nome,Sobrenome,Cpf.";
               r.WriteLine("Nome;Sobrenome;Cpf.");
                foreach (Cliente Client in clientes)
                {
                  //  conteudo += Client.Nome + "," + Client.Sobrenome + "," + Client.Cpf + "\n";
                    var linha = Client.Nome + ";" + Client.Sobrenome + ";" + Client.Cpf;
                    r.WriteLine(linha);
                }
              //  File.WriteAllText(CaminhoBaseClientes(), conteudo);
                r.Close();
            }

        }
        public void ListaClientes()
        {
            var ListaDeClientes = Cliente.LerClientes();

        
            foreach (var Client in ListaDeClientes)
            {
                Console.WriteLine($"Nome:{Client.Nome}\nSobrenome:{Client.Sobrenome}\nCPF:{Client.Cpf}");

            }
        }

        private static string ArquivoDatabaseClientes()
        {
            return ConfigurationManager.AppSettings["DatabaseArquivoCadastro"];
        }

        public static List<Cliente> LerClientes()
        {
            var clientes = new List<Cliente>();
            if (File.Exists(ArquivoDatabaseClientes()))
            {
                using (StreamReader arquivo = File.OpenText(ArquivoDatabaseClientes()))
                {

                    string linha;
                    int i = 0;
                    while ((linha = arquivo.ReadLine()) != null)
                    {
                        i++;
                        if (i == 1) continue;
                        {
                            var ClienteArquivo = linha.Split(';');
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

        public void CriarCliente()
        {
            var Cliente1 = new Cliente("Maria", "Souza", "222.222.222-22");
            Cliente1.GravarClienteDatabase();


            var Cliente2 = new Cliente("Pedro", "Ferreira", "333.333.333-33");
            Cliente2.GravarClienteDatabase();


            var Cliente3 = new Cliente("Luciana", "Gomes", "444.444.444-44");
            Cliente3.GravarClienteDatabase();

          
        }
    }
}
