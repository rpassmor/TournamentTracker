using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using TrackerLibrary.Models;

namespace TrackerLibrary.Connections
{
    public interface IDataConnection
    {
        Prize CreatePrize(Prize model);
        Person CreatePerson(Person model);
        Team CreateTeam(Team model);
        void CreateTournament(Tournament model);
        List<Person> GetPerson_All();
        List<Team> GetTeam_All();
        List<Tournament> GetTournament_All();
    }
}
