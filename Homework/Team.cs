using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Team
    {

        public Coach Coach { get; set; }
        public List<FootballPlayer> Players { get; set; }

        public double AverageAge
        {
            get { return Players.Average(p => p.Age); }
        }
    }
}
