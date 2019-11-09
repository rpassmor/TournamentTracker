using System;
using System.Collections.Generic;
using System.Text;
using TournamentBracket.Connections;

namespace TournamentBracket
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; } = new List<IDataConnection>;

        public static void InitializedConnections(bool database, bool textFiles)
        {
            if (database)
            {
                // TODO - Set up SQL Connector properly
                SqlConnector sql = new SqlConnector();
                Connections.Add(sql);
            }

            if (textFiles)
            {
                // TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                Connections.Add(text);
            }
        }
    }
}
