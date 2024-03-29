﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using TrackerLibrary.Connections;
using System.Data.SqlClient;

namespace TrackerLibrary
{
    public static class GlobalConfig
    {
        public const string PrizesFile = "PrizeModels.csv";
        public const string PersonFile = "PersonFile.csv";
        public const string TeamFile = "TeamModels.csv";
        public const string TournamentFile = "TournamentModels.csv";
        public const string MatchupFile = "MatchupModels.csv";
        public const string MatchupEntryFile = "MatchupEntryFile.csv";
        public static IDataConnection Connection { get; private set; }

        public static void InitializedConnections(DatabaseType db)
        {
            if (db == DatabaseType.Sql)
            {
                // TODO - Create the SQL Connection
                SqlConnector sql = new SqlConnector();
                Connection = sql;
            }
            else if (db == DatabaseType.TextFile)
            {
                // TODO - Create the Text Connection
                TextConnector text = new TextConnector();
                Connection = text;
            }
        }
         
        public static string CnnString(string name)
        {
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }               

    }
}