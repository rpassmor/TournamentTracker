using System;
using System.Collections.Generic;
using System.Text;
using TrackerLibrary.Models;

namespace TrackerLibrary.Connections
{
    public class TextConnector : IDataConnection
    {
        public Prize CreatePrize(Prize model)
        {
            // Load the text file
            // Convert the text to a List<Prize>
            // Find the max ID
            // Add new record with new ID (max + 1)
            // Convert the prizes to a list<string>
            // Save the list<string> to the text file

        }   
        
    }
}
