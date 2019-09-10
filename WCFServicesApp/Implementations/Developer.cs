using System;
using System.Collections.Generic;
using System.Linq;
using WCFServicesApp.Interfaces;

namespace WCFServicesApp.Implementations
{
    public class Developer : IDeveloper
    {
        public void AddJsonDeveloper(string request)
        {
            var dev = Helpers.Serializer.JsonStringToEntity<Domain.Developer>(request);
        }

        public void AddXmlDeveloper(string request)
        {
            var dev = Helpers.Serializer.XmlStringToEntity<Domain.Developer>(request);
        }

        public Domain.Developer GetDeveloperById(string id)
        {
            return Persistence.Data.GetDeveloperById(Convert.ToInt32(id));
        }

        public List<Domain.Developer> GetDevelopers()
        {
            return Persistence.Data.GetDevelopers().ToList();
        }

        public void JsonPost(Domain.Developer developer)
        {
            Persistence.Data.AddDeveloper(developer);
        }

        public void XmlPost(Domain.Developer developer)
        {
            Persistence.Data.AddDeveloper(developer);
        }
    }
}