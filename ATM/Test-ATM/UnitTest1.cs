
using Microsoft.VisualStudio.TestPlatform.TestHost;
using ATM;
namespace Test_ATM
{
	public class UnitTest1
	{


		[Theory]
		[InlineData(-1, -1,10)]
		[InlineData(0, -1,10)]
		[InlineData(2, 12,10)]
		[InlineData(2.3, 12.3,10)]

		public void ReturnValueForDeposit(decimal numToTest, decimal expectedValue,decimal balance)
		{
			ATM.Program.Balance = balance;
			Assert.Equal(expectedValue, ATM.Program.Deposit(numToTest));
		}

		
		[Theory]
		[InlineData(5, -2, 0)]
		public void TestIFBalanceEqualZeroInWithdraw(decimal numToTest, decimal expectedValue, decimal balance)
		{
			
			ATM.Program.Balance = balance;
			Assert.Equal(expectedValue, ATM.Program.Withdraw(numToTest));


		}

		[Theory]
		[InlineData(-3, -1,10)]
		[InlineData(0, -1,10)]
		[InlineData(10.5, -1,10)]
		[InlineData(2, 8,10)]
		[InlineData(2.3, 7.7,10)]
		

		public void ReturnValueForWithdraw(decimal numToTest, decimal expectedValue,decimal balance)
		{
			ATM.Program.Balance = balance;
			Assert.Equal(expectedValue, ATM.Program.Withdraw(numToTest));
		}



		[Theory]
		[InlineData(0, 0,0)]
		public void ReturnTheBalanceValueEqule0(decimal numToTest, decimal expectedValue, decimal balance)
		{
			ATM.Program.Balance = balance;
			Assert.Equal(expectedValue, ATM.Program.ViewBalance());
		}

		[Theory]
		[InlineData(15, 15, 15)]
		public void ReturnTheBalanceValueEqule15(decimal numToTest, decimal expectedValue, decimal balance)
		{
			ATM.Program.Balance = balance;
			Assert.Equal(expectedValue, ATM.Program.ViewBalance());
		}

	}
}