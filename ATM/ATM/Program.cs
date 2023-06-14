namespace ATM
{
	public class Program
	{
		static public decimal Balance = 0;
		static void Main(string[] args)
		{
			UserInterface();
		}
		//UserInterface
		public static void UserInterface()
		{
			string process = "";
			while (process !="4") {
				Console.WriteLine("Please Enter the number of the process you want from list " +
					"1.View Balance 2.Withdraw 3.Deposit 4.Exit");
				process = Console.ReadLine();
				if (process == "1") { 
					Console.WriteLine($"Your Current Balance is: {ViewBalance(Balance)}");
				}
				else if (process == "2") {

					Console.WriteLine("Please enter the value to be deducted");
					try
					{
						decimal truncation = decimal.Parse(Console.ReadLine());
						decimal result= Withdraw(truncation);
						if (result == -2)
						{
							Console.WriteLine("Your Balance is 0 we can't complete the Process");
						}
						else if (result == -1)
						{
							Console.WriteLine("the Proccess did Not completed You Entered a Negative value");
						}
						else
						{
							Console.WriteLine("the Proccess Done successfuly");
							Console.WriteLine($"Your Current Balance is: {result}");
						};
					}
					catch (NullReferenceException ex)
					{
						Console.WriteLine(ex.Message);
						Console.WriteLine("the Proccess did Not completed You did Not Enter any Value");
					}
				}
				else if (process == "3") {

					Console.WriteLine("Please enter the value to be added");
					try
					{
						decimal add = decimal.Parse(Console.ReadLine());
						decimal result=Deposit(add);
						if(result == -1) {
							Console.WriteLine("the Proccess did Not completed Your Balance is Not enough");
						}
						else {
							Console.WriteLine("the Proccess Done successfuly");
							Console.WriteLine($"Your Current Balance is: {result}"); }
						
					}
					catch (NullReferenceException ex)
					{
						Console.WriteLine(ex.Message);
						Console.WriteLine("the Proccess did Not completed You did Not Enter any Value");
					}

				}
				else { Console.WriteLine("Please choose a number from the list"); }
			
			}
		}
		//UserInterface

		//ViewBalance

		public static decimal ViewBalance(decimal balance)
		{

			return balance;
		}
		//ViewBalance

		//Withdraw
		public static decimal Withdraw(decimal truncation)
		{

			if (Balance == 0) {
				return -2;
			}

			else if (Balance >= truncation && truncation > 0)
			{
				Balance = Balance - truncation;
				
				return Balance;
			}
			else
			{
				
				return -1;
			}

		}
		//Withdraw

		//Deposit
		public static decimal Deposit(decimal deposit)
		{
			
			
				
				if (deposit<=0)
				{
					
					return -1;
					
				}
				else
				{
					Balance += deposit;	
				
					return Balance;

				}
			}

		//Deposit


	}
}