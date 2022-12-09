
namespace BowlingScores;

public class BowlingGame
{

    private readonly List<BowlingGameRecord> _games = new();

    public void AddAPlayerScore(string name, int score)
    {
        _games.Add(new BowlingGameRecord(name, score));
    }

    public List<BowlingGameRecord> HighScores()
    {
        var highScore = _games.Select(g => g.score).Max();

        return _games.Where(g => g.score == highScore).ToList();

    }

    public List<BowlingGameRecord> LowScores()
    {
        var lowScore = _games.Select(g => g.score).Min();

        return _games.Where(g => g.score == lowScore).ToList();
    }




}
