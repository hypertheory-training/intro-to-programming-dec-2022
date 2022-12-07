

using Banking.Domain;

namespace Banking.UnitTests;

public class GoldAccountBenefits
{
    [Fact]
    public void GetBonusOnDeposit()
    {
        // Change the Context
        var account = new GoldAccount();
        var openingBalance = account.GetBalance();
        var amountToDeposit = 100M;
        var expectedBonus = 10M;

        account.Deposit(amountToDeposit);

        Assert.Equal(openingBalance + amountToDeposit + expectedBonus, 
            account.GetBalance());

    }
}
