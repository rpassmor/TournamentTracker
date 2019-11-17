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
        List<Person> GetPerson_All();
    }
}
