using PlayerApp.Models;
namespace PlayerApp

{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player[] players = {
                new Player(101, "Ramesh", 23),
                new Player(102, "Suresh", 13),
                new Player(103, "Ajesh"),
                new Player(104, "Rakesh", 44),
                new Player(105, "Mahesh", 21),
            };

            Player maxAgePlayer = Player.WhoIsElder(players);
            Console.WriteLine($"Player with maximum age is {maxAgePlayer}");
        }

    }
}
