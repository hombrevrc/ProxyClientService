using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace GettingStartedHost
{
  [ServiceContract(Namespace = "http://acleite/myservices/2018/12/02")]
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
    bool Calc();
    [OperationContract]
    void CloseCalc();
  }

}
