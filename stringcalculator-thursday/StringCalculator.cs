

namespace StringCalculator;

public class StringCalculator
{
    private readonly ILogger _logger;

    public StringCalculator(ILogger logger)
    {
        _logger = logger;
    }

    public int Add(string numbers)
    {
      var answer = numbers == "" ? 0 :
        numbers.Split(',', '\n').Select(int.Parse).Sum();

        _logger.Write(answer.ToString());
        return answer;
        
    }
}

public interface ILogger
{
    void Write(string message);
}