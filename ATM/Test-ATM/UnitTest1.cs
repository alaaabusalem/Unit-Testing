
using Microsoft.VisualStudio.TestPlatform.TestHost;
using ATM;
namespace Test_ATM
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			ATM.Program.Balance = 10;

			Assert.Equal(12, ATM.Program.Deposit(2));
		}

		/*[Theory]
		[InlineData()]
		[InlineData()]
		[InlineData()]
		[InlineData()]
		[InlineData()]
		public void ReturnValueIfNither(int numToTest, string expectedValue)
		{
			Assert.Equal(expectedValue, Program.Deposit(numToTest));
		}*/

	}
}