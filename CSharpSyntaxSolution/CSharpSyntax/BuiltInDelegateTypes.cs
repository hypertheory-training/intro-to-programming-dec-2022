
namespace CSharpSyntax;

public class BuiltInDelegateTypes
{
    [Fact]
    public void Actions()
    {
        var bob = new Employee();
       
        Action<string> doIt;

        doIt = bob.Hire;
        doIt("Looks good"); // Bob is Hired!

        doIt = bob.Fire;

        doIt("Turns out he's a creep"); // Bob is fired.


        Action<decimal, string, DateTime> giveRaise = bob.GiveRaise;
        giveRaise(123.42M, "Jeff", DateTime.Now);


        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        var evens = numbers.Where(NumberUtilities.IsEven);

        // "Select is Map"
        // "Where is Filter"
        var answer = "1,2,3,4,5".Split(',').Select(int.Parse).Sum();

    }
}


public class Employee {
    public void Hire(string department) { }
    public void Fire(string reason) { }

    public void GiveRaise(decimal amount, string whoApproved, DateTime whenApplied) { }
 }


public class NumberUtilities
{
    public static bool IsEven(int n) => n % 2 == 0;

    public static bool IsOdd(int n) => n % 2 != 0;
}