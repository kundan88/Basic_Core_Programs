using System;
public class Program
{
    int num1, num2, num3;
    public void readData()
    {

        Console.Write("Input the 1st number :");
        num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the  2nd number :");
        num2 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input the 3rd  number :");
        num3 = Convert.ToInt32(Console.ReadLine());

    }

    public void showData()
    {
        if (num1 > num2)
        {
            if (num1 > num3)
            {
                Console.Write("The 1st Number is the greatest among three. \n\n");
            }
            else
            {
                Console.Write("The 3rd Number is the greatest among three. \n\n");
            }
        }
        else if (num2 > num3)
            Console.Write("The 2nd Number is the greatest among three \n\n");
        else
            Console.Write("The 3rd Number is the greatest among three \n\n");
    }
          public static void Main(string[] args)
          {
           Program p=new Program();
           p.readData();
           p.showData();
         }
     }