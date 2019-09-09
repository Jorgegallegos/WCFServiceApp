using System.Collections.Generic;
using System.IO;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WCFServicesApp.Interfaces
{
    [ServiceContract]
    public interface IDeveloper
    {
        [WebInvoke(Method ="GET" ,
            UriTemplate = "/GetOne/{id}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat =WebMessageFormat.Xml,
            BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        Domain.Developer GetDeveloperById(string id);

        [WebInvoke(Method = "GET",
            UriTemplate = "/GetAll", 
            ResponseFormat = WebMessageFormat.Xml,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        IEnumerable<Domain.Developer> GetDevelopers();

        [WebInvoke(Method = "POST",
            UriTemplate = "/Add",
            ResponseFormat = WebMessageFormat.Xml,
            RequestFormat = WebMessageFormat.Xml,
            BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        void AddDeveloper(Domain.Developer developer);
    }
}
