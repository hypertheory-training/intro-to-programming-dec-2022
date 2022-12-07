

using Banking.UnitTests.TestDoubles;

namespace Banking.UnitTests;

public class GoldAccountBenefits
{
    [Fact]
    public void GetBonusOnDeposit()
    {
        var account = new BankAccount(new StubbedBonusCalculator());
        var openingBalance = account.GetBalance();
        var amountToDeposit = 92.42M;
        var expectedBonus = 42M;

        account.Deposit(amountToDeposit);

        Assert.Equal(openingBalance + amountToDeposit + expectedBonus, 
            account.GetBalance());

    }
}
