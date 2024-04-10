using System.ServiceModel;

namespace CalculatorService.Models
{
    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        int Add(int num1, int num2);

        [OperationContract]
        int Subtract(int num1, int num2);

        [OperationContract]
        int Multiply(int num1, int num2);

        [OperationContract]
        int Divide(int num1, int num2);
    }
}
