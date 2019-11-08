﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentBracket.Models
{
    public class Matchup
    {
        public List<MatchupEntry> Entries { get; set; }
        public Team Winner { get; set; }
        public int MatchupRound { get; set; }

    }
}
