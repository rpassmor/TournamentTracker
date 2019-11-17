using System;
using System.Collections.Generic;
using System.Text;

namespace TrackerLibrary.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        /// <summary>
        /// Each member a a team
        /// </summary>
        public List<Person> TeamMembers { get; set; } = new List<Person>();
        

    }
}   
