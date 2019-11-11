using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;
using TrackerLibrary.Connections.TextHelper;
using System.Linq;
using System.IO;

namespace TrackerLibrary.Connections
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
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

    }
}

