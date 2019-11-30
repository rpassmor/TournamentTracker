using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class Tournament
    {
        /// <summary>
        /// The unique identifier for the tournament
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The name of the current tounament
        /// </summary>
        public string TounamentName { get; set; }
        /// <summary>
        /// The entry fee of the tounament, if there is one
        /// </summary>
        public decimal EntryFee { get; set; }
        /// <summary>
        /// List of teams entered in the tounament
        /// </summary>
        public List<Team> EnteredTeams { get; set; } = new List<Team>();
        /// <summary>
        /// Optional prize winnings
        /// </summary>
        public List<Prize> Prizes { get; set; } = new List<Prize>();
        /// <summary>
        /// The round the tounament is currently on
        /// </summary>
        public List<List<Matchup>> Rounds { get; set; } = new List<List<Matchup>>();
    }
}
