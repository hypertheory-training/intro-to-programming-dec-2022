using System.Reflection.Metadata;

namespace CSharpSyntax;


public class NumberFilter
{
    public List<int> FilterOutEvens(List<int> numbers)
    {
        return Filter(numbers, new IsOddFilterPredicate());
    }
    public List<int> FilterOutOdds(List<int> numbers)
    {
        return Filter(numbers, new IsEvenPredicate());
    }

    private List<int> Filter(List<int> numbers, FilterPredicate pred)
    {
        var results = new List<int>();
        foreach (var number in numbers)
        {
          
            if (pred.IsMatch(number))
            {
                results.Add(number);
            }
        }
        return results;
    }


    private bool IsOdd(int number)
    {
        return number % 2 != 0;
    }
}

public interface FilterPredicate
{
    bool IsMatch(int x);
}

public class IsOddFilterPredicate : FilterPredicate
{
    public bool IsMatch(int x)
    {
        return x %2 != 0;
    }
}

public class IsEvenPredicate : FilterPredicate
{
    public bool IsMatch(int x)
    {
        return x % 2 == 0;
    }
}