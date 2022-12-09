using BowlingScores;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Principal;

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

    // if what they entered is an integer, cool, if not, show an error.
    //int.TryParse()
    //var score = int.Parse(Console.ReadLine()); // we'll worry about this later.

    if(int.TryParse(Console.ReadLine(), out var score))
    {
        game.AddAPlayerScore(name!, score);

    } else
    {
        Console.WriteLine("Enter a number for a score, you bone head!");
        
    }
    
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




