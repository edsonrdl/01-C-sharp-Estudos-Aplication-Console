namespace _13_LinkedList._01_Coleção
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
