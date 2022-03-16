using System;

class EvenOddNum
{
    int x;
    public void readData()
    {
        Console.WriteLine("Enter a any No. ");
        x=Convert.ToInt32(Console.ReadLine());

    }
    public void Even_Odd()
    {
        if (x % 2 == 0)
        {
            Console.Write("Entered Number is an Even Number");
            Console.Read();
        }
        else
        {
            Console.Write("Entered Number is an Odd Number");
            Console.Read();
        }
    }
    public static void Main(string[] args)
    {
        EvenOddNum e=new EvenOddNum();
   
        e.readData();
        e.Even_Odd();
    }
}
