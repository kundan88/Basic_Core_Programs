using System;
public class Program
{
	int x, y, q, r;
	public void readData()
    {
		Console.Write("Enter first number:");
		x = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter second number:");
		y = Convert.ToInt32(Console.ReadLine());

	}
	public void getData()
    {
		q = x / y;
		r = x % y;
		Console.WriteLine("Quotient is:" + q);
		Console.WriteLine("Remainder is:" + r);

	}
	public static void Main(string[] args)
	{
		Program p=new Program();
		p.readData();
		p.getData();
		
		

		

	}
}