namespace _11_Colecoes._02_Dicionarios._01_Declaracao
{
     class Veiculo
    {
        public void CriarVeiculo()
        {
            Dictionary<int, string> veiculo = new Dictionary<int, string>();
            veiculo.Add(12, "Caminhão");
            veiculo.Add(4, "Carro");
            veiculo.Add(6, "Avião");
            veiculo.Add(2, "Motocicleta"); 

             Console.WriteLine("Exibir :{0}",veiculo.Count);

             Dictionary<int, string>.ValueCollection valores = veiculo.Values;
             foreach (var v in veiculo)
             {
                Console.WriteLine(v);

            }
        }
    }
}
