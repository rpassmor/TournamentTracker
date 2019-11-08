using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentBracket.Models
{
    public class Prize
    {
        /// <summary>
        ///  Place for the prize payout
        /// </summary>
        public int PlaceNumber { get; set; }
        public string PlaceName { get; set; }
        public decimal PrizeAmount { get; set; }
        public double PrizePercentage { get; set; }

    }
}
