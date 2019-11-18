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

