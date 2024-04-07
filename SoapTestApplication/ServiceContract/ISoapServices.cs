using System.ServiceModel;
using SoapTestApplication.DataContract;
using SoapTestApplication.FaultContract;

namespace SoapTestApplication.ServiceContract

{
    [ServiceContract(Namespace = "http://mock.namespace.gr", Name = "MockSoapAPI")]
    public interface ISoapServices
    {
        [OperationContract(Action = "CreateApplicationRequest", ReplyAction = "CreateApplicationResponse",
            Name = "CreateApplication")]
        [FaultContract(typeof(WebServiceError), Name = "CreateApplicationError")]
        WebServiceResponse CreateApplicationBinding(WebServiceRequest createApplicationRequest);

        [OperationContract(Action = "SetFinancialAssetRequest", ReplyAction = "SetFinancialAssetResponse",
            Name = "SetFinancialAsset")]
        [FaultContract(typeof(WebServiceError), Name = "SetFinancialAssetError")]
        WebServiceResponse SetFinancialAssetBinding(WebServiceRequest setFinancialAssetRequest);
    }

    public class SoapServices : ISoapServices
    {
        public WebServiceResponse CreateApplicationBinding(WebServiceRequest createApplicationRequest)
        {
            return new WebServiceResponse(1L, "Success");
        }

        public WebServiceResponse SetFinancialAssetBinding(WebServiceRequest setFinancialAssetRequest)
        {
            throw new FaultException<WebServiceError>(
                new WebServiceError(101L, "MOCK ERROR DESCRIPTION"), 
                new FaultReason("FAULT REASON"), 
                new FaultCode("10001"), 
                "ACTION" ); 
            
            // throw new FaultException(
            //     new FaultReason("FAULT REASON"), 
            //     new FaultCode("10001"), 
            //     "SetFinancialAssetError" );
            
        }
    }
}