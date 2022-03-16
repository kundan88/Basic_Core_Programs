using System;

    class Program
    {
        int n, i;
        public void readData()
        {
            Console.WriteLine("Enter the Number:");
            n = int.Parse(Console.ReadLine());
        }

        public void PrimeFact()
        {
            Console.WriteLine("Factors:");
            for (i = 1; i <= n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }
    
        public static void Main(string[] args)
        {
        Program p=new Program();
        p.readData();
        p.PrimeFact();
        }
        }

