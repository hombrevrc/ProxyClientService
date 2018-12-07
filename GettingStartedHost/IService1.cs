using System.ServiceModel;

namespace GettingStartedHost
{
  [ServiceContract(Namespace = "http://acleite/myservices/2018/12/07")]
  public interface ICalculator
  {
    [OperationContract]
    double Add(double n1, double n2);
    [OperationContract]
    double Subtract(double n1, double n2);
    [OperationContract]
    double Multiply(double n1, double n2);
    [OperationContract]
    double Divide(double n1, double n2);
    [OperationContract]
    bool NotifyClientStartup();
  }

}
