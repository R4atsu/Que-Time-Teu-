using System;
					
public class Program
{
	public static void Main()
	{
		String time1;
		String time2;
		int mundial1;
		int mundial2;
			
		Console.WriteLine("Insira o Nome do primeiro Time");
		time1 = Console.ReadLine();
		Console.WriteLine("Insira o Nome do segundo Time");
		time2 = Console.ReadLine();
		
		Console.WriteLine("Insira a Quantidade de Mundiais FIFA o " + time1 + " conquistou?");
		mundial1 = Convert.ToInt16(Console.ReadLine());
		Console.WriteLine("Insira a Quantidade de Mundiais FIFA o " + time2 + " conquistou?");
		mundial2 = Convert.ToInt16(Console.ReadLine());
		
		if (mundial1 > mundial2){
			Console.WriteLine("O " + time1 + " é maior que " + time2);
		}
		else if (mundial2 > mundial1){
			Console.WriteLine(("O " + time2 + " é maior que " + time1));
		}
		else if (mundial1 == mundial2)
			Console.WriteLine("Os dois são Pequenos");
	}
}