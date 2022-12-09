
namespace BowlingScores.UnitTests;

public class Issue98
{

    [Fact]
    public void TheBadBehavior()
    {
        var game = new BowlingGame();

        game.HighScores();

    }


    [Fact]
    public void TheNewBehavior()
    {
        var game = new BowlingGame();

        var results = game.HighScores();

        Assert.Empty(results);
    }
}
