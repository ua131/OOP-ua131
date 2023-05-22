using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Game
    {
        public Team1 TeamOne { get; }
        public Team2 TeamTwo { get; }
        public Referee GameReferee { get; }

        public List<Goal> Goals { get; }

        public string GameResult { get; set; }
        public string Winner { get; set; }
        public Game()
        {
            TeamOne = new Team1();
            TeamTwo = new Team2();
            GameReferee = new Referee();
            Goals = new List<Goal>();
        }
    }
}
