using System;
using System.Diagnostics;
using System.IO;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;

namespace GettingStartedHost
{

  public class CalculatorService : ICalculator
  {

    private void w(string s)
    {
      try
      {
        using (StreamWriter sw = File.AppendText("logCalculatorService.txt"))
        {
          Console.WriteLine(DateTime.Now.ToShortTimeString() + " - " + s);
          sw.WriteLine(DateTime.Now.ToShortTimeString() + " - " + s);

        }
      }
      catch (Exception)
      {

        throw;
      }
    }

    public double Add(double n1, double n2)
    {
      double result = n1 + n2;


      try
      {
        Console.WriteLine(result.ToString());
        Debug.WriteLine(result.ToString());
      }
      catch (Exception)
      {
        return 0;

      }

      return result;
    }

    public double Subtract(double n1, double n2)
    {
      double result = n1 - n2;

      Console.WriteLine(result.ToString());
      Debug.WriteLine(result.ToString());
      return result;
    }

    public double Multiply(double n1, double n2)
    {
      double result = n1 * n2;

      Console.WriteLine(result.ToString());
      return result;
    }

    public double Divide(double n1, double n2)
    {

      double result = n1 / n2;

      Console.WriteLine(result.ToString());
      return result;


    }

    public bool NotifyClientStartup()
    {

      Console.WriteLine("Client Just Started");

      return true;

    }






  }


  public class MetadataExchange : IMetadataExchange
  {
    public IAsyncResult BeginGet(Message request, AsyncCallback callback, object state)
    {
      try
      {
        Debug.WriteLine("IAsyncResult BeginGet");
      }
      catch (Exception ex)
      {
        Debug.WriteLine(ex.Message);
      }
      return null;
    }

    public Message EndGet(IAsyncResult result)
    {
      try
      {
        Debug.WriteLine("Message EndGet");
      }
      catch (Exception ex)
      {
        Debug.WriteLine(ex.Message);
      }
      return null;
    }

    public Message Get(Message request)
    {
      try
      {
        Debug.WriteLine("Message Get");
      }
      catch (Exception ex)
      {
        Debug.WriteLine(ex.Message);
      }
      return null;
    }
  }
}
