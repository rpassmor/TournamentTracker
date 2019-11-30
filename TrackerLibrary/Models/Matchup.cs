using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class Matchup
    {
        /// <summary>
        /// Unique identifier for the Matchup.
        /// </summary>
        public int Id { get; set; }
        public List<MatchupEntry> Entries { get; set; } = new List<MatchupEntry>();
        /// <summary>
        /// The ID from the db that will be used to identify the winner
        /// </summary>
        public int WinnerId { get; set; }
        public Team Winner { get; set; }
        public int MatchupRound { get; set; }
        public string DisplayName 
        {
            get 
            {
                string output = "";
                foreach (MatchupEntry me in Entries)
                {
                    if (me.TeamCompeting != null)
                    {
                        if (output.Length == 0)
                        {
                            output = me.TeamCompeting.TeamName;
                        }
                        else
                        {
                            output += $" vs. {me.TeamCompeting.TeamName}";
                        }
                    }
                    else
                    {
                        output = "Matchup not yet determined";
                        break;
                    }
                }
                return output;
            } 
        }

    }
}
