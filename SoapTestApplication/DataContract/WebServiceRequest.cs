using System.Runtime.Serialization;

namespace SoapTestApplication.DataContract;

[DataContract]
public class WebServiceRequest
{
    public WebServiceRequest()
    {
    }

    public WebServiceRequest(string institutionVatNumber, string requestData, string encryptedRequestDataHash)
    {
        InstitutionVatNumber = institutionVatNumber ;
        RequestData = requestData;
        EncryptedRequestDataHash = encryptedRequestDataHash;
    }

    [DataMember(IsRequired = true)] public string InstitutionVatNumber { get; set; }
    [DataMember(IsRequired = true)] public string RequestData { get; set; }
    [DataMember(IsRequired = true)] public string EncryptedRequestDataHash { get; set; }
}