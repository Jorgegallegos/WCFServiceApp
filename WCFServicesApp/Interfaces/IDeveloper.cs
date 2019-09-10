using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace WCFServicesApp.Interfaces
{
    [ServiceContract]
    public interface IDeveloper
    {
        [WebInvoke(Method = "POST",
            UriTemplate = "AddDeveloper/Json",
            ResponseFormat = WebMessageFormat.Json,
            RequestFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        void JsonPost(Domain.Developer developer);

        [WebInvoke(Method = "POST",
            UriTemplate = "AddDeveloper",
            ResponseFormat = WebMessageFormat.Xml,
            RequestFormat = WebMessageFormat.Xml,
            BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        void XmlPost(Domain.Developer developer);

        [WebInvoke(Method = "GET",
            UriTemplate = "AddJson?request={request}",
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        void AddJsonDeveloper(string request);

        [XmlSerializerFormat]
        [WebInvoke(Method = "GET",
            UriTemplate = "AddXml?request={request}",
            ResponseFormat = WebMessageFormat.Xml,
            BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        void AddXmlDeveloper(string request);

        [WebInvoke(Method = "GET",
           UriTemplate = "GetOne/Json/{id}",
           ResponseFormat = WebMessageFormat.Json,
           BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        Domain.Developer GetDeveloperById(string id);

        [XmlSerializerFormat]
        [WebInvoke(Method = "GET",
            UriTemplate = "GetAll",
            ResponseFormat = WebMessageFormat.Xml,
            BodyStyle = WebMessageBodyStyle.Bare)]
        [OperationContract]
        List<Domain.Developer> GetDevelopers();
    }
}
