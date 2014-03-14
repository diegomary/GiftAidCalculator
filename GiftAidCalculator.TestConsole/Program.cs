using System;

namespace GiftAidCalculator.TestConsole
{
	class Program
	{
		static void Main(string[] args)
		{           
			// Calc Gift Aid Based on Previous
			Console.WriteLine("Please Enter donation amount:");
            AidCalculator.DonationAmount = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the currant tax rate:");
            AidCalculator.CurrentTaxRate = decimal.Parse(Console.ReadLine());
            Console.WriteLine("Please Enter the event type (for supplement) return for no event known ");
            AidCalculator.CharityEvent = Console.ReadLine();
            Console.WriteLine(AidCalculator.GiftAidAmount());
			Console.WriteLine("Press any key to exit.");
			Console.ReadLine();
		}       
	}
}
