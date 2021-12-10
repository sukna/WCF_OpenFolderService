using System.ServiceModel;
using System.ServiceModel.Web;

namespace WCF_OpenFolder
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        [WebInvoke(Method ="GET",
            UriTemplate = "/openFolder?path={path}",
            RequestFormat = WebMessageFormat.Json,
            ResponseFormat = WebMessageFormat.Json,
            BodyStyle = WebMessageBodyStyle.Wrapped)]
        string OpenFolder(string path);
    }
}
