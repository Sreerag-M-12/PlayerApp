using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp.Models
{
    internal class Player
    {
        static int DEFAULT_AGE = 18;
        
        public int Id { get; }
        public string Name { get; }
        public int Age { get; }

        public Player(int id, string name) 
        {
            Id = id;
            Name = name;
            Age = DEFAULT_AGE;
        }

        public Player(int id, string name, int age) : this(id, name) 
        { 
            Age = age;
        }

        public static Player WhoIsElder(Player[] players)
        {
            int MaxAge = 0;
            Player playerWithMaxAge = null;
            foreach (Player player in players) {
                if (player.Age > MaxAge) { 
                    MaxAge = player.Age;
                    playerWithMaxAge = player;
                }
            }
            return playerWithMaxAge;
        }

        public override string ToString()
        {
            Console.WriteLine("==========MAX AGE=========");
            return $"Player id: {Id} \n" +
                $"Player Name: {Name} \n" +
                $"Player age: {Age} \n";
        }
    }
}
