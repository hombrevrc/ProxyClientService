using System;
using System.IO;

namespace GettingStartedLib
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

    private System.Diagnostics.Process c = null;

    public bool Calc()
    {
      if (c == null)
      {

        try
        {
          c = System.Diagnostics.Process.Start("calc");
          w("Calc Running");
          return true;
        }
        catch (Exception)
        {
          throw;
        }
      }
      return false;
    }

    public void CloseCalc()
    {
      try
      {
        if (c != null)
        {
          c.Kill();
          c = null;
          w("Calc Closed");
        }
      }
      catch (Exception)
      {
        throw;
      }

    }



  }
}
