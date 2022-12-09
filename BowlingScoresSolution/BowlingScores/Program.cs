using BowlingScores;
using System.Reflection;
using System.Runtime.CompilerServices;

Console.WriteLine("Bowling Score Tool!");

// Ask in a loop for the name and score of each player.
// If the user enters a blank line for the name, then we are done adding players.

Console.WriteLine("Enter your bowlers name. If you are done, just hit enter");
var game = new BowlingGame();


while(true)
{

    Console.Write("Enter the name of the bowler: ");
    var name = Console.ReadLine();
    if(name == "")
    {
        break; // Jump out of the loop.
    }
    Console.Write($"What was {name}'s Score? :");
    var score = int.Parse(Console.ReadLine()); // we'll worry about this later.

    game.AddAPlayerScore(name, score);
}


// Who won? Who had the highest score.
foreach(var winner in game.HighScores())
{
    Console.WriteLine($"Winner: {winner.player} with a score of {winner.score}");
}

foreach(var loser in game.LowScores())
{
    Console.WriteLine($"Loser: {loser.player} with a score of {loser.score}");
}