using System.Reflection.Metadata;

namespace CSharpSyntax;

//public delegate bool IsMatch(int x);

public class NumberFilter
{
    public List<int> FilterOutEvens(List<int> numbers)
    {
        //return Filter(numbers, delegate (int x)
        //{
        //    return x % 2 != 0;
        //});

        return Filter(numbers, n => n % 2 != 0);
    }
    public List<int> FilterOutOdds(List<int> numbers)
    {

        return Filter(numbers, n => n % 2 == 0);
        //return Filter(numbers, delegate (int x)
        //{
          
        //    return x % 2 == 0;
        //});
    }

    private List<int> Filter(List<int> numbers, Predicate<int> isMatch)
    {
        var results = new List<int>();
        foreach (var number in numbers)
        {
          
            if (isMatch(number))
            {
                results.Add(number);
            }
        }
        return results;
    }


    //private bool IsOdd(int number)
    //{
    //    return number % 2 != 0;
    //}

    //private bool IsEven(int number)
    //{
    //    return number % 2 == 0;
    //}
}


