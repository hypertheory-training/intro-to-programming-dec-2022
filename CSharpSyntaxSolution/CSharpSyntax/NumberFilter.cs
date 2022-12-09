namespace CSharpSyntax;


public class NumberFilter
{
    public List<int> FilterOutEvens(List<int> numbers)
    {
        return Filter(numbers);
    }
    public List<int> FilterOutOdds(List<int> numbers)
    {
        return Filter(numbers);
    }

    private List<int> Filter(List<int> numbers)
    {
        var results = new List<int>();
        foreach (var number in numbers)
        {
          
            if (IsOdd(number))
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

