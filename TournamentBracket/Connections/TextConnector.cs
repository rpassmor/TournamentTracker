using System;
using System.Collections.Generic;
using System.Text;
using TournamentBracket.Models;

namespace TournamentBracket.Connections
{
    public class TextConnector : IDataConnection
    {
        // TODO - Wire up the CreatePirze for text files.
        public Prize CreatePrize(Prize model)
        {
            model.Id = 1;
            return model;
        }
    }
}
