﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TournamentBracket
{
    public static class GlobalConfig
    {
        public static List<IDataConnection> Connections { get; private set; }

        public static void initializedConnections(bool database, bool textFiles)
        {
            if (database)
            {
              // TODO - Create the SQL Connection

            }
            if (textFiles)
            {
              // TODO - Create the Text Connection

            }
        }
    }
}