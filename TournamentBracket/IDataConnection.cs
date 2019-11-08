using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TournamentBracket.Models;

namespace TournamentBracket
{
    public interface IDataConnection
    {
        Prize CreatePrize(Prize model);
    }
}
