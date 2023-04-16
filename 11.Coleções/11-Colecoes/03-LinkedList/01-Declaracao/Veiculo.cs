namespace _11_Colecoes._03_LinkedList._01_Declaracao
{
     class Veiculo
    {
        public void LinkedListAddFirst()
        {
            //AddFirst vai adicionar sempre no começo da lista

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
        public void LinkedListAddLast()
        {
            //AddLast vai adicionar sempre no final da lista

            LinkedList<string> veiculo=new LinkedList<string>();
            veiculo.AddLast("Carro");
            veiculo.AddLast("Avião");
            veiculo.AddLast("Caminhão");
            veiculo.AddLast("Motocicleta");
            foreach (string v in veiculo)
            {
                Console.WriteLine(v);
            }
        }
        public void LinkedListAddAfter()
        {
            //AddAfter vai adicionar depois do item da lista

            LinkedList<string> veiculo = new LinkedList<string>();
            veiculo.AddFirst("Carro");
            veiculo.AddFirst("Avião");
            veiculo.AddFirst("Caminhão");
            veiculo.AddFirst("Motocicleta");

            var no = veiculo.FindLast("Motocicleta") ;
            veiculo.AddAfter(no, "Navio");
            foreach (string v in veiculo)
            {
                Console.WriteLine(v);
            }
        }
        public void LinkedListAddBefore()
        {
            //AddBefore vai adicionar antes do item da lista

            LinkedList<string> veiculo = new LinkedList<string>();
            veiculo.AddFirst("Carro");
            veiculo.AddFirst("Avião");
            veiculo.AddFirst("Caminhão");
            veiculo.AddFirst("Motocicleta");
            //Precisa criar a nova variável 
            var no = veiculo.FindLast("Motocicleta") ;
            veiculo.AddBefore(no, "Navio");
            foreach (string v in veiculo)
            {
                Console.WriteLine(v);
            }
        }  
        public void LinkedListClean()
        {
            //Clear vai limpar o LinkedList

            LinkedList<string> veiculo = new LinkedList<string>();
            veiculo.AddFirst("Carro");
            veiculo.AddFirst("Avião");
            veiculo.AddFirst("Caminhão");
            veiculo.AddFirst("Motocicleta");
            veiculo.Clear();
            Console.WriteLine(veiculo);
        }
        public void LinkedListFind()
        {
            //AddBefore vai adicionar antes do item da lista

            LinkedList<string> veiculo = new LinkedList<string>();
            veiculo.AddFirst("Carro");
            veiculo.AddFirst("Avião");
            veiculo.AddFirst("Caminhão");
            veiculo.AddFirst("Motocicleta");

            if (veiculo.Find("Carro")==null)
            {
                Console.WriteLine("Encontrado");
            }
            else
            {
                Console.WriteLine("Não encontrado");
            }
            
        }
        public void LinkedListRemoveFirst()
        {
            //RemoveFirst vai remover sempre no começo da lista

            LinkedList<string> veiculo = new LinkedList<string>();
            veiculo.AddFirst("Carro");
            veiculo.AddFirst("Avião");
            veiculo.AddFirst("Caminhão");
            veiculo.AddFirst("Motocicleta");

            veiculo.RemoveFirst();
            foreach (string v in veiculo)
            {
                Console.WriteLine(v);
            }
          
        }
        public void LinkedListRemoveLast()
        {
            //RemoveLast vai remover sempre no final da lista

            LinkedList<string> veiculo = new LinkedList<string>();
            veiculo.AddLast("Carro");
            veiculo.AddLast("Avião");
            veiculo.AddLast("Caminhão");
            veiculo.AddLast("Motocicleta");

            veiculo.RemoveLast();
            foreach (string v in veiculo)
            {
                Console.WriteLine(v);
            }
            
        }
    }

}
