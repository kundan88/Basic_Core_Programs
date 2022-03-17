namespace FlippingCoin
{
    class Program
    {
        int heads = 0;
        int tails = 0;
        int result = 0;
        public void showData()
        {
            Console.WriteLine("Let's flip a Coin");
            Random Rand = new Random();
            for (int i = 0; i < 5; i++)
            {
                result = Rand.Next(0, 2);

                if (result < 0.5)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }

            }
            Console.WriteLine("heads was flipped " + heads);
            Console.WriteLine("tails was flipped " + tails);


        }


        public static void Main(string[] args)
        {
            Program p=new Program();
            p.showData();
        }
    }
}
      
            
            


            
