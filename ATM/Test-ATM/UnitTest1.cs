
using Microsoft.VisualStudio.TestPlatform.TestHost;
using ATM;
namespace Test_ATM
{
	public class UnitTest1
	{
		

		[Theory]
		[InlineData(-1,-1)]
		[InlineData(0,-1)]
		[InlineData(2,12)]
		[InlineData(2.3,12.3)]
		
		public void ReturnValueForDeposit(decimal numToTest, decimal expectedValue)
		{
			ATM.Program.Balance = 10;
			Assert.Equal(expectedValue, ATM.Program.Deposit(numToTest));
		}


		[Fact]
		public void TestIFBalanceEqualZeroInWithdraw()
		{
			int truncation = 5;
			ATM.Program.Balance = 0;
			Assert.Equal(-2, ATM.Program.Withdraw(truncation));


		}
		[Theory]
		[InlineData(-3, -1)]
		[InlineData(0, -1)]
		[InlineData(10.5, -1)]
		[InlineData(2, 8)]
		[InlineData(2.3, 7.7)]
		

		public void ReturnValueForWithdraw(decimal numToTest, decimal expectedValue)
		{
			ATM.Program.Balance = 10;
			Assert.Equal(expectedValue, ATM.Program.Withdraw(numToTest));
		}



		[Fact]
		public void ReturnTheBalanceValueEqule0()
		{
			ATM.Program.Balance = 0;
			Assert.Equal(0, ATM.Program.ViewBalance());
		}

		[Fact]
		public void ReturnTheBalanceValueEqule15()
		{
			ATM.Program.Balance = 15;
			Assert.Equal(15, ATM.Program.ViewBalance());
		}

	}
}