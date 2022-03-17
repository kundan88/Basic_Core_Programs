using System;

public class Program
{
    
    char ch;
    public void readData()
    {
        Console.Write("Input an Alphabet (A-Z or a-z) : ");
        ch = Convert.ToChar(Console.ReadLine().ToLower());
        
    }
    public void ShowData()
    {
        int i = ch;
        if (i >= 48 && i <= 57)
        {
            Console.Write("You entered a number, Please enter an alpahbet.");
        }
        else
        {
            switch (ch)
            {
                case 'a':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'i':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'o':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'u':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                case 'e':
                    Console.WriteLine("The Alphabet is vowel");
                    break;
                default:
                    Console.WriteLine("The Alphabet is not a vowel");
                    break;
            }
        }
        

        Console.ReadKey();
    }
          public static void Main(string[] args)
          {
           Program p=new Program();
        p.readData();
        p.ShowData();

       
          }
}
