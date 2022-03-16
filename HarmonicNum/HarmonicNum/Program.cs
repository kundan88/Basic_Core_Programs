using System;

class Program
{
	
	public void Harminic()
    {
        float harmonic = 1;
        int N =2;
        for (int i = 2; i <= N; i++)
        {
            harmonic += (float)1 / i;
        }
        Console.WriteLine("harminic num :" +harmonic);

        
    }



public static void Main(string[] args)
    {
		Program p=new Program();
        p.Harminic();
	
    }
}