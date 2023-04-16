namespace _11_Colecoes._01_Listas._01_Declaracao
{
     class Veiculo
    {
        public void ListAdd()
        { 
            //Adiciona na lista
            List<String> veiculos1 = new List<string>();
            veiculos1.Add("Caminhão");
               veiculos1.Add("Carro");


               foreach (var v in veiculos1)
             {
                Console.WriteLine(v);
             }
        } 
        public void ListRange()
        { 
            //Cria uma nova lista sem ter que passar todos os valores

            List<String> veiculos1 = new List<string>();
            List<String> veiculos2 = new List<string>();
               veiculos1.Add("Caminhão");
               veiculos1.Add("Carro");


               foreach (var v in veiculos1)
             {
                Console.WriteLine(v);

            }

               veiculos2.AddRange(veiculos1);
               foreach (var v2 in veiculos2)
               {
                   Console.WriteLine(v2);

               }
        }
        public void ListContains()
        {
            //Verifica se existe na lista
            List<String> veiculos1 = new List<string>();
            veiculos1.Add("Caminhão");
            veiculos1.Add("Carro");
            veiculos1.Add("Avião");
            veiculos1.Add("Motocicleta");


            foreach (var v in veiculos1)
            {
                Console.WriteLine(v);

            }

            if (veiculos1.Contains("Avião"))
            {
                Console.WriteLine("Existe na lista");
            }
            else
            {
                Console.WriteLine("Não existe na lista");
            }
           
        }
        public void ListClear()
        {
            //Verifica se existe na lista
            List<String> veiculos1 = new List<string>();
            veiculos1.Add("Caminhão");
            veiculos1.Add("Carro");
            veiculos1.Add("Avião");
            veiculos1.Add("Motocicleta");
            veiculos1.Clear();


            foreach (var v in veiculos1)
            {
                Console.WriteLine(v);

            }
        } 
        public void ListCopyTo()
        {
            //CopyTo() vai copiar de uma lista para outra
            //.CopyTo(index, array[], indexArray, qtd copiado);
            //Passando a partir de qual elemento quer copiar 
            List<String> veiculos1 = new List<string>();
            string[] veiculos2 = new string[3];
            veiculos1.Add("Caminhão");
            veiculos1.Add("Carro");
            veiculos1.Add("Avião");
            veiculos1.Add("Motocicleta");
            veiculos1.Add("Navio");
            
            Console.WriteLine("QUANTIDADE DE ITENS: {0}", veiculos1.Count);


            foreach (var v in veiculos1)
            {
                Console.WriteLine(v);

            }
            veiculos1.CopyTo(2, veiculos2, 0, 3);


            foreach (var v2 in veiculos2)
            {
                Console.WriteLine(v2);

            }
            Console.WriteLine("QUANTIDADE DE ITENS: {0}", veiculos2.Length);
        }
        public void ListIndexOf()
        {
            //IndexOf() vai mostrar a posição do item
            List<String> veiculos1 = new List<string>();
            
            veiculos1.Add("Caminhão");
            veiculos1.Add("Carro");
            veiculos1.Add("Avião");
            veiculos1.Add("Motocicleta");
            veiculos1.Add("Navio");
            var v1= veiculos1.IndexOf("Navio");

            Console.WriteLine(v1);



        }
        public void ListInsert()
        {
            //Insert() vai inserir ma posição  o item 
            List<String> veiculos1 = new List<string>();
            
            veiculos1.Add("Caminhão");
            veiculos1.Add("Carro");
            veiculos1.Add("Avião");
            veiculos1.Add("Motocicleta");
            veiculos1.Insert(0,"Navio");

            foreach (var v in veiculos1)
            {
                Console.WriteLine(v);

            }
            
        }
        public void ListLasIndexof()
        {
            //LastIndexOf() vai exibir o item que esta na ultima posição mesmo que tenha items com o mesmo nome antes 
            List<String> veiculos1 = new List<string>();

            veiculos1.Add("Caminhão");
            veiculos1.Add("Carro");
            veiculos1.Add("Navio");
            veiculos1.Add("Avião");
            veiculos1.Add("Motocicleta");
            veiculos1.Add("Avião");
            veiculos1.Add("Bicicleta");
            veiculos1.Add("ônibus");
            
            Console.WriteLine("Quantidade de itens :{0}", veiculos1.Count);
            
            foreach (var v in veiculos1)
            {
                Console.WriteLine(v);

            }
          var LastIndexOf =  veiculos1.LastIndexOf("Avião");
          Console.WriteLine("Está na posição:{0}", LastIndexOf);

        }
    }
}
