using System;
using System.Collections.Generic;
using System.Text;
using TournamentBracket.Models;

namespace TournamentBracket
{
    public class SqlConnector : IDataConnection
    {
        // TODO - Make the CreatePrize method actually save to the database
        /// <summary>
        /// Saves a new prize to the database
        /// </summary>
        /// <param name="model"></param>
        /// <returns>The prize information, including the unique identifier</returns>
        public Prize CreatePrize(Prize model)
        {
            model.Id = 1;
            return model;
        }
    }
}
