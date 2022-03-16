using System;
public class Program
{
    int x, y, temp;
    public void readData()
    {
        Console.Write("\nInput the First Number : ");
        x = int.Parse(Console.ReadLine())
            ;
        Console.Write("\nInput the Second Number : ");
        y = int.Parse(Console.ReadLine());


    }
    public void showData()
    {
        temp = x;
        x = y;
        y = temp;

        Console.Write("\nAfter Swapping : ");
        Console.Write("\nFirst Number : " + x);
        Console.Write("\nSecond Number : " + y);
        Console.Read();
    }
    public static void Main(string[] args)
    {
        Program p=new Program();
        p.readData();
        p.showData();
        
       
    }
}
