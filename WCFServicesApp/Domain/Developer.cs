using System.Runtime.Serialization;

namespace WCFServicesApp.Domain
{

    [DataContract]
    public class Developer
    {
        [DataMember]
        public int DeveloperID { get; set; }
        [DataMember]
        public string FullName { get; set; }
        [DataMember]
        public string Position { get; set; }
        [DataMember]
        public string Skills { get; set; }
        [DataMember]
        public string Location { get; set; }
    }
}