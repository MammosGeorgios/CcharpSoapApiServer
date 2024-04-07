using System.ServiceModel;

namespace SoapTestApplication.SoapService

{
    [ServiceContract]
    public interface ISumService
    {
        [OperationContract]
        string Sum(int num1, int num2);
    }

    public class SumService : ISumService
    {
        public string Sum(int num1, int num2)
        {
            return $"Sum of two number is: {num1 + num2}";
        }

    }
}