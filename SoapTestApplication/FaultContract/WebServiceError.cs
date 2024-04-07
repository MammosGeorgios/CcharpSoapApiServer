using System.Runtime.Serialization;

namespace SoapTestApplication.FaultContract;

[DataContract]
public class WebServiceError 
{
    public WebServiceError(long errorCode, string description)
    {
        ErrorCode = errorCode;
        Description = description;
    }

    [DataMember(IsRequired = true)] public long ErrorCode;
    [DataMember] public string Description;
}