
namespace CSharpSyntax;

public class NumberFilterTests
{

    [Fact]
    public void CanFilterOutEvenNumbers()
    {
        // Given
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var expected = new List<int> { 1, 3, 5, 7, 9 };
        var numberFilter = new NumberFilter();

        // when
        List<int> results = numberFilter.FilterOutEvens(numbers);

        // Then

        Assert.Equal(expected, results);
    }

    [Fact]
    public void CanFilterOutOddNumbers()
    {
        // Given
        var numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        var expected = new List<int> { 2,4,6,8 };
        var numberFilter = new NumberFilter();

        // when
        List<int> results = numberFilter.FilterOutOdds(numbers);

        // Then

        Assert.Equal(expected, results);
    }
}
