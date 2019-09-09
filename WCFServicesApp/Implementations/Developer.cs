using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using WCFServicesApp.Domain;
using WCFServicesApp.Interfaces;

namespace WCFServicesApp.Implementations
{
    public class Developer : IDeveloper
    {
        public void AddDeveloper(Domain.Developer developer)
        {
            Persistence.Data.AddDeveloper(developer);
        }

        public Domain.Developer GetDeveloperById(string id)
        {
            int.TryParse(id, out int ident);

            return Persistence.Data.GetDeveloperById(ident);
        }

        public IEnumerable<Domain.Developer> GetDevelopers()
        {
            return Persistence.Data.GetDevelopers();
        }
    }
}