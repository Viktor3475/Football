using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Match
{
    public class Team
    {
        public Coach Coach { get; set; }

        public List<Football_Player> Players { get; set; }

        public double AverageAge => Players.Average(p => p.Age);

        public string Name {  get; set; }

        public Team(Coach coach,string name)
        {
            Coach = coach;
            Name = name;
            Players = new List<Football_Player>();
        }

        public void AddPlayer(Football_Player player)
        {
            if (Players.Count > 22)
                throw new Exception("A team can have up to 22 players.");

            Players.Add(player);
        }

    }
}
