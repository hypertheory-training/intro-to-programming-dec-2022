
namespace StringCalculator;

public class StringCalculator
{

    public int Add(string numbers)
    {
        var delimeters = new List<char> { ',', '\n' };
        if (numbers.StartsWith("//"))
        {
            delimeters.Add(numbers[2]);
            numbers = numbers.Substring(4);
        }
        return numbers == "" ? 0 :numbers.Split(delimeters.ToArray()).Select(int.Parse).Sum();

    }
}
