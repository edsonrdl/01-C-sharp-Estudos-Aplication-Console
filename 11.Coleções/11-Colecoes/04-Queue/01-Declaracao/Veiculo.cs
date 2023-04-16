namespace _11_Colecoes._04_Queue
{
     class Veiculo
    {
        public void QueueDeclaracao()
        {
            string[] v = new[] { "Caminhão", "Carro" };
            Queue<string> veiculo = new Queue<string>(v);
            Console.WriteLine("Quantidade de :{0}", veiculo.Count);


        }
        public void QueueEnQueue()
        { //Enqueue adiciona na Fila o item sempre no final
            string[] v = new[] { "Caminhão", "Carro" };
            Queue<string> veiculo = new Queue<string>(v);

            veiculo.Enqueue("Navio");

            Console.WriteLine("Quantidade de :{0}", veiculo.Count);
            foreach (var v1 in veiculo)
            {
                Console.WriteLine(v1);
            }
            


        } 
        public void QueueDeQueue()
        { //Enqueue adiciona na Fila o item sempre no final
            string[] v = new[] { "Caminhão", "Carro" };
            Queue<string> veiculo = new Queue<string>(v);


            Console.WriteLine("Quantidade de :{0}", veiculo.Count);
            foreach (var v1 in veiculo)
            {
                Console.WriteLine(v1);
            }

            veiculo.Dequeue();

            Console.WriteLine("Quantidade de :{0}", veiculo.Count);
            foreach (var v1 in veiculo)
            {
                Console.WriteLine(v1);
            }
        }
    }
}
