using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentBracket.Models
{
    public class Team
    {
        /// <summary>
        /// Each member a a team
        /// </summary>
        public List<Person> TeamMembers { get; set; } = new List<Person>();
        public string TeamName { get; set; }

    }
}   
