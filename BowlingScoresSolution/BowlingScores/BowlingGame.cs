
namespace BowlingScores;

public class BowlingGame
{

    private readonly List<BowlingGameRecord> _games = new();

    public void AddAPlayerScore(string name, int score)
    {
        _games.Add(new BowlingGameRecord(name, score));
    }

    public IEnumerable<BowlingGameRecord> HighScores()
    {
        if (HasNoGames()) return _games;
        // What's the high score?
        var highScore = _games.Select(g => g.score).Max();
        // Who all got that score?
        return _games.Where(g => g.score == highScore).ToList();

    }

    public IEnumerable<BowlingGameRecord> LowScores()
    {
        // Never type private, always refactor to it.
        if (HasNoGames()) return _games;
        // What is the low score?
        var lowScore = _games.Select(g => g.score).Min();
        // Who all got that score?
        return _games.Where(g => g.score == lowScore).ToList();
    }

    private bool HasNoGames()
    {
        return _games.Count == 0;
    }




}
