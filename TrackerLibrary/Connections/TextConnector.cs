using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using TrackerLibrary.Connections.TextHelper;
using System.Linq;
using System.IO;
using System.Configuration;

namespace TrackerLibrary.Connections
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        private const string PersonFile = "PersonFile.csv";
        private const string TeamFile = "TeamModels.csv";
        public Prize CreatePrize(Prize model)
        {
            // Load the text file
            // Convert the text to a List<Prize>
            List<Prize> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the max ID
            int currentId = 1;
            if (prizes.Count > 0)
            {
                currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            }

            model.Id = currentId;

            // Add new record with new ID (max + 1)
            prizes.Add(model);

            // Convert the prizes to a list<string>
            // Save the list<string> to the text file
            prizes.SaveToPrizeFile(PrizesFile);

            return model;
        }
        public Person CreatePerson(Person model)
        {
            List<Person> person = PersonFile.FullFilePath().LoadFile().ConvertToPerson();

            int currentId = 1;
            if (person.Count > 0)
            {
                currentId = person.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;
           
            person.Add(model);
            person.SaveToPersonFile(PersonFile);
            
            return model;
        }

        public List<Person> GetPerson_All()
        {
            return PersonFile.FullFilePath().LoadFile().ConvertToPerson();
        }

        public Team CreateTeam(Team model)
        {
            List<Team> teams = TeamFile.FullFilePath().LoadFile().ConvertToTeamModels(PersonFile);

            int currentId = 1;
            if (teams.Count > 0)
            {
                currentId = teams.OrderByDescending(x => x.Id).First().Id + 1;
            }
            model.Id = currentId;

            teams.Add(model);

            teams.SaveToTeamFile(TeamFile);
            return model;
        }
    }
}

