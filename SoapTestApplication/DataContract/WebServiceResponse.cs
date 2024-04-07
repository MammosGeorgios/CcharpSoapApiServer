using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace SoapTestApplication.DataContract;

[DataContract]
public class WebServiceResponse
{
    public WebServiceResponse()
    {
    }

    public WebServiceResponse(long status, string response)
    {
        Status = status;
        Response = response;
    }

    [DataMember(IsRequired = true)] public long Status { get; set; }
    [DataMember(IsRequired = true)] public string Response { get; set; }
}