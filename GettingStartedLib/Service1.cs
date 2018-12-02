using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Configuration;
using System.Configuration;
using System.Text;
using System.ServiceModel.Description;
using System.Reflection;
using System.IO;

namespace GettingStartedLib
{
  public class CalculatorService : ICalculator
  {

    private   void w(string s)
    {
      using (StreamWriter sw = File.AppendText("logCalculatorService.txt"))
      {
        sw.WriteLine(DateTime.Now.ToShortTimeString() + " - " + s);
      }
    }

    public double Add(double n1, double n2)
    {
      double result = n1 + n2;
      w($"Received Add({n1},{n2})");
      w($"Return: {result}");
      return result;
    }

    public double Subtract(double n1, double n2)
    {
      double result = n1 - n2;
      w($"Received Subtract({n1},{n2})");
      w($"Return: {result}");
      return result;
    }

    public double Multiply(double n1, double n2)
    {
      double result = n1 * n2;
      w($"Received Multiply({n1},{n2})");
      w($"Return: {result}");
      return result;
    }

    public double Divide(double n1, double n2)
    {
      double result = n1 / n2;
      w($"Received Divide({n1},{n2})");
      w($"Return: {result}");
      return result;
    }

    public void Calc()
    {
      

    }

     


  }
}
