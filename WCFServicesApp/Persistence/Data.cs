using System.Collections.Generic;
using System.Linq;

namespace WCFServicesApp.Persistence
{
    public class Data
    {
        public static Domain.Developer GetDeveloperById(int id)
        {
            return Seed().FirstOrDefault(x => x.DeveloperID == id);
        }

        public static IEnumerable<Domain.Developer> GetDevelopers()
        {
            return Seed();
        }

        private static IEnumerable<Domain.Developer> Seed()
        {
            return new List<Domain.Developer>
            {
                new Domain.Developer {DeveloperID = 1,FullName ="John Luiton"},
                new Domain.Developer {DeveloperID = 2,FullName ="Mary Well"},
                new Domain.Developer {DeveloperID = 3,FullName ="Rick Levis"},
                new Domain.Developer {DeveloperID = 4,FullName ="Coleman Regal"},
                new Domain.Developer {DeveloperID = 5,FullName ="Mark Ton"},
            };
        }
    }
}