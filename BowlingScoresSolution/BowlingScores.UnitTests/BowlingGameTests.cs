
namespace BowlingScores.UnitTests;

public class BowlingGameTests
{
    [Fact]
    public void CanFindHighestScores()
    {
        var game = new BowlingGame();

       

        var expectedWinners = new List<BowlingGameRecord>
        {
            new BowlingGameRecord("Jeff", 300),
            new BowlingGameRecord("Tim", 300)
        };
        var others = new List<BowlingGameRecord>
        { new BowlingGameRecord("Sean", 220)};

        var expectedLosers = new List<BowlingGameRecord>()
        {
            new BowlingGameRecord("Stacey", 200),
            new BowlingGameRecord("Earl", 200)
        };

        foreach(var p in expectedWinners)
        {
            game.AddAPlayerScore(p.player, p.score);
        }
        foreach(var p in expectedLosers)
        {
            game.AddAPlayerScore(p.player, p.score);
        }
        foreach(var p in others)
        {
            game.AddAPlayerScore(p.player, p.score);
        }

        Assert.Equal(expectedWinners, game.HighScores());
        Assert.Equal(expectedLosers, game.LowScores());

    }
}
