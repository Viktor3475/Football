using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;
using static Match.Game;

namespace Match
{
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public List<Referee> AssistantReferees { get; set; }
        public List<Goal> Goals { get; set; }




        public Game(Team team1,Team team2,Referee referee,List<Referee> assistantReferees)
        {
            if(team1.Players.Count != 11 || team2.Players.Count != 11)
            {
                throw new Exception("Each team must have exactly 11 players.");
            }
            Team1 = team1;
            Team2 = team2;
            Referee = referee;
            AssistantReferees = assistantReferees;
            Goals = new List<Goal>();
        }

        public string GetResult()
        {
            int team1Goals = Goals.Count(g => Team1.Players.Contains(g.Player));
            int team2Goals = Goals.Count(g => Team2.Players.Contains(g.Player));
            return $"{Team1.Coach.Name} vs. {Team2.Coach.Name}: {team1Goals} - {team2Goals}";
        }

        public string GetWinner()
        {
            int team1Goals = Goals.Count(g => Team1.Players.Contains(g.Player));
            int team2Goals = Goals.Count(g => Team2.Players.Contains(g.Player));
            if (team1Goals > team2Goals)
                return $"{Team1.Name} wins!";
            else if (team2Goals > team1Goals)
                return $"{Team2.Name} wins!";
            else
                return "It's a draw!";
        }

        public string GoalsByPlayers()
        {
            StringBuilder sb = new();

            Goals.ForEach(goal =>
            {
                sb.AppendLine($"Player {goal.Player.Name} scored at {goal.Minute} minute!");
            });

            return sb.ToString();           
        }

       

        public class Goal
        {
            public int Minute { get; set; }
            public Football_Player Player { get; set; }

            public Goal(int minute, Football_Player player)
            {
                Minute = minute;
                Player = player;
            }
        }
    }
}
