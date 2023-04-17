namespace _07_Encapsulamento._03_Indexadores
{
    class Dirigir
    {
        //O indexado permite objeto ser utilizado como array

        private int[] Idade=new int[5]{12,13,24,10,32};

        public int this[int i]{
            get
            {
                return Idade[i];
            }
            set
            {
                if (value >= 18)
                {
                    Console.WriteLine("Pode dirigir");
                }
                else
                {
                    Console.WriteLine("Não pode dirigir");
                }
            }
        }
    }
}
