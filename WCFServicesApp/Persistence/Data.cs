using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace WCFServicesApp.Persistence
{
    public class Data
    {
        static List<Domain.Developer> list;

        static Data()
        {
            list = new List<Domain.Developer>()
            {
                new Domain.Developer {DeveloperID = 1,FullName ="John Doe", Position = ".NET Developer"},
                new Domain.Developer {DeveloperID = 2,FullName ="Mary Well", Position = "Java Developer"},
            };           
        }

        public static Domain.Developer GetDeveloperById(int id)
        {
            return list.FirstOrDefault(x => x.DeveloperID == id);
        }

        public static IEnumerable<Domain.Developer> GetDevelopers()
        {
            return list;
        }

        public static void AddDeveloper(Domain.Developer developer)
        {
           list.Add(developer);
        }
    }
}