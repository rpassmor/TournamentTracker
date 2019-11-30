using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;
using System.IO;
using System.Linq;
using TrackerLibrary.Models;
using System.Windows.Forms;

namespace TrackerLibrary.Connections.TextHelper
{
    public static class TextConnectorProcessor
    {
        // return the full file path of the fileName
        public static string FullFilePath(this string fileName) 
        {
            return $@"{ConfigurationManager.AppSettings["filePath"]}\{fileName}";  
        }

        // Load the text file
        public static List<string> LoadFile(this string file)
        {
            if (!File.Exists(file))
            {
                return new List<string>();
            }

            return File.ReadAllLines(file).ToList();
        }

        // Convert the text to List<Prize>
        public static List<Prize> ConvertToPrizeModels(this List<string> lines)
        {
            List<Prize> output = new List<Prize>();
            foreach(string line in lines)
            {
                string[] cols = line.Split(',');

                Prize p = new Prize();
                p.Id = int.Parse(cols[0]);
                p.PlaceNumber = int.Parse(cols[1]);
                p.PlaceName = cols[2];
                p.PrizeAmount = decimal.Parse(cols[3]);
                p.PrizePercentage = double.Parse(cols[4]);
                output.Add(p);
            }
            return output;
        }
        public static List<Person> ConvertToPerson(this List<string> lines)
        {
            List<Person> output = new List<Person>();
            foreach(string line in lines)
            {
                string[] cols = line.Split(',');

                Person p = new Person();
                p.Id = int.Parse(cols[0]);
                p.FirstName = cols[1];
                p.LastName = cols[2];
                p.EmailAddress = cols[3];
                p.CellphoneNumber = cols[4];
                output.Add(p);
            }
            return output;
        }
        public static List<Team> ConvertToTeamModels(this List<string> lines, string personFileName)
        {
            List<Team> output = new List<Team>();
            List<Person> people = personFileName.FullFilePath().LoadFile().ConvertToPerson();


            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                Team t = new Team();
                t.Id = int.Parse(cols[0]);                
                t.TeamName = cols[1];

                string[] personIds = cols[2].Split('|');

                foreach (string id in personIds)
                {
                    t.TeamMembers.Add(people.Where(x => x.Id == int.Parse(id)).First());
                }
                output.Add(t);
            }

            return output;
        }
        public static List<Tournament> ConvertToTournamentModels(this List<string> lines,
            string teamFileName,
            string personFileName,
            string prizeFileName)
        {
            // Id,TournamentName, EntryFee, (id|id|id - Entered Teams), (id|id|id - Prizes), (Rounds - id^id^id|id^id^id)
            List<Tournament> output = new List<Tournament>();
            List<Team> teams = teamFileName.FullFilePath().LoadFile().ConvertToTeamModels(personFileName);
            List<Prize> prizes = prizeFileName.FullFilePath().LoadFile().ConvertToPrizeModels();
            List<Matchup> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');
                Tournament tm = new Tournament();
                tm.Id = int.Parse(cols[0]);
                tm.TounamentName = cols[1];
                tm.EntryFee = decimal.Parse(cols[2]);
                string[] teamIds = cols[3].Split('|');

                foreach (string id in teamIds)
                {
                    tm.EnteredTeams.Add(teams.Where(x => x.Id == int.Parse(id)).First());
                }
                string[] prizeIds = cols[4].Split('|');
                foreach (string id in prizeIds)
                {
                    tm.Prizes.Add(prizes.Where(x => x.Id == int.Parse(id)).First());
                }
                
                // Capture Rounds information
                string[] rounds = cols[5].Split('|');
                
                foreach (string round in rounds)
                {
                    string[] msText = round.Split('^');
                    List<Matchup> ms = new List<Matchup>();

                    foreach ( string matchupModelTextId in msText)
                    {
                        ms.Add(matchups.Where(x => x.Id == int.Parse(matchupModelTextId)).First());
                    }
                    tm.Rounds.Add(ms);
                }
                output.Add(tm);
            }
            return output;
        }
        public static void SaveToPrizeFile( this List<Prize> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (Prize p in models)
            {
                lines.Add($"{p.Id},{p.PlaceNumber},{p.PlaceName},{p.PrizeAmount},{p.PrizePercentage}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        public static void SaveToPersonFile(this List<Person> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (Person p in models)
            {
                lines.Add($"{p.Id},{p.FirstName},{p.LastName},{p.EmailAddress},{p.CellphoneNumber}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        public static void SaveToTeamFile(this List<Team> models, string fileName)
        {
            List<string> lines = new List<string>();

            foreach (Team t in models)
            {
                lines.Add($"{t.Id},{t.TeamName},{ConvertPeopleListToString(t.TeamMembers)}");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        public static void SaveToTournamentFile(this List<Tournament> models, string fileName)
        {
            List<string> lines = new List<string>();
            foreach ( Tournament tm in models)
            {
                lines.Add($@"{ tm.Id},
                             { tm.TounamentName},
                             { tm.EntryFee},
                             { ConvertTeamListToString(tm.EnteredTeams) },
                             { ConvertToPrizeListToString(tm.Prizes) },
                             { ConvertRoundListToString(tm.Rounds) }");
            }
            File.WriteAllLines(fileName.FullFilePath(), lines);
        }
        public static void SaveRoundsToFile(this Tournament model, string matchupFile, string matchupEntryFile)
        {
            // Loop through each round
            // Loop through each matchup
            // Get the id for the new matchup and save the record
            // Loop through each Entry, get the id, and save it

            foreach(List<Matchup> round in model.Rounds)
            {
                foreach (Matchup matchup in round)
                {
                    // Load all of the matchup from file
                    // get the top id and add one
                    // store the id
                    // save the match record
                    matchup.SaveMatchupToFile(matchupFile, matchupEntryFile);

                    
                }
            }
        }
        public static List<MatchupEntry> CovertToMatchupEntryModels(this List<string> lines)
        {
            // id = 0
            // TeamCompeting = 1
            // Score = 2
            // ParentMatchup = 3

            List<MatchupEntry> output = new List<MatchupEntry>();

            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                MatchupEntry me = new MatchupEntry();
                me.Id = int.Parse(cols[0]);
                if (cols[1].Length == 0)
                {
                    me.TeamCompeting = null;
                }
                else
                {
                    me.TeamCompeting = LookupTeamById(int.Parse(cols[1]));
                }
                me.Score = double.Parse(cols[2]);
                int parentId = 0;
                if (int.TryParse(cols[3], out parentId))
                {
                    me.ParentMatchup = LookupMatchupById(parentId);
                }
                else
                {
                    me.ParentMatchup = null;
                }
                output.Add(me);
            }
            return output;
        }
        public static void SaveMatchupToFile(this Matchup matchup, string matchupFile, string matchupEntryFile)
        {
            List<Matchup> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            int currentId = 1;
            if (matchups.Count >0)
            {
                currentId = matchups.OrderByDescending(x => x.Id).First().Id + 1;
            }
            matchup.Id = currentId;

            matchups.Add(matchup);

/*            // Save to file
            List<string> lines = new List<string>();
            foreach (Matchup m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }
                lines.Add($"{m.Id},{""},{m.Winner.Id}");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);*/

            foreach (MatchupEntry entry in matchup.Entries)
            {
                entry.SaveEntryToFile(matchupEntryFile);
            }

            // Save to file again
            List<string> lines = new List<string>();
            foreach (Matchup m in matchups)
            {
                string winner = "";
                if (m.Winner != null)
                {
                    winner = m.Winner.Id.ToString();
                }
                lines.Add($"{m.Id},{ConvertToMatchupEntryListToString(m.Entries)},{m.Winner.Id}");
            }
            File.WriteAllLines(GlobalConfig.MatchupFile.FullFilePath(), lines);
        }
        public static void SaveEntryToFile(this MatchupEntry entry, string matchupEntryFile)
        {
            List<MatchupEntry> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().CovertToMatchupEntryModels();
            int currentId = 1;
            if (entries.Count >0)
            {
                currentId = entries.OrderByDescending(x => x.Id).First().Id + 1;
            }
            entry.Id = currentId;

            
            entries.Add(entry);
            List<string> lines = new List<string>();
            foreach (MatchupEntry e in entries)
            {
                string parent = "";
                if (e.ParentMatchup != null)
                {
                    parent = e.ParentMatchup.Id.ToString();
                }
                string teamCompeting = "";
                if (e.TeamCompeting != null)
                {
                    teamCompeting = e.TeamCompeting.Id.ToString();
                }
                lines.Add($"{e.Id},{teamCompeting},{e.Score},{parent}");
            }
            File.WriteAllLines(GlobalConfig.MatchupEntryFile.FullFilePath(), lines);
        }
        private static List<MatchupEntry> ConvertStringToMatchupEntryModel(string input)
        {
            string[] ids = input.Split('|');
            List<MatchupEntry> output = new List<MatchupEntry>();
            List<MatchupEntry> entries = GlobalConfig.MatchupEntryFile.FullFilePath().LoadFile().CovertToMatchupEntryModels();

            foreach (string id in ids)
            {
                output.Add(entries.Where(x => x.Id == int.Parse(id)).First());

            }
            return output;
        }
        private static Team LookupTeamById(int id)
        {
            List<Team> teams = GlobalConfig.TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(GlobalConfig.PersonFile);
            return teams.Where(x => x.Id == id).First();
        }
        private static Matchup LookupMatchupById(int id)
        {
            List<Matchup> matchups = GlobalConfig.MatchupFile.FullFilePath().LoadFile().ConvertToMatchupModels();
            return matchups.Where(x => x.Id == id).First();
        }
        public static List<Matchup> ConvertToMatchupModels(this List<string> lines)
        {
            // id=0
            // Entries=1(pipe delimited by id)
            // Winner = 2
            // matchupRound =3
            List<Matchup> output = new List<Matchup>();
            foreach (string line in lines)
            {
                string[] cols = line.Split(',');

                Matchup p = new Matchup();
                p.Id = int.Parse(cols[0]);
                p.Entries = ConvertStringToMatchupEntryModel(cols[1]);
                if (cols[2].Length == 0)
                {
                    p.Winner = null;
                }
                else
                {
                    p.Winner = LookupTeamById(int.Parse(cols[2]));
                }
                p.MatchupRound = int.Parse(cols[3]);
                output.Add(p);
            }
            return output;
        }
        private static string ConvertRoundListToString(List<List<Matchup>> rounds)
        {
            string output = "";
            if (rounds.Count == 0)
            {
                return "";
            }
            foreach (List<Matchup> r in rounds)
            {
                output += $"{ConvertMatchupListToString(r)}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }
        private static string ConvertMatchupListToString(List<Matchup> matchups)
        {
            {
                string output = "";
                if (matchups.Count == 0)
                {
                    return "";
                }
                foreach (Matchup m in matchups)
                {
                    output += $"{m.Id}^";
                }
                output = output.Substring(0, output.Length - 1);
                return output;
            }
        }
        private static string ConvertToPrizeListToString(List<Prize> prizes)
        {
            string output = "";
            if (prizes.Count == 0)
            {
                return "";
            }
            foreach (Prize p in prizes)
            {
                output += $"{p.Id}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }

        private static string ConvertToMatchupEntryListToString(List<MatchupEntry> entries)
        {
            string output = "";
            if (entries.Count == 0)
            {
                return "";
            }
            foreach (MatchupEntry e in entries)
            {
                output += $"{e.Id}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }
        private static string ConvertTeamListToString(List<Team> teams)
        {
            string output = "";
            if (teams.Count == 0)
            {
                return "";
            }
            foreach (Team t in teams)
            {
                output += $"{t.Id}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }
        private static string ConvertPeopleListToString(List<Person> people)
        {
            string output = "";

            if (people.Count == 0)
            {
                return "";
            }

            foreach (Person p in people)
            {
                output += $"{p.Id}|";
            }
            output = output.Substring(0, output.Length - 1);
            return output;
        }
    }
}

