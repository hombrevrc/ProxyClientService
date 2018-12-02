using System;
using System.Diagnostics;
using System.IO;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;

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

      if (c != null)
      {
        Process proc = Process.GetProcessesByName("Calc")[0];
        SetForegroundWindow(proc.MainWindowHandle);
        Thread.Sleep(1000);
        SendKeys.SendWait("{ESC}"); SendKeys.Flush();
        SendKeys.SendWait(result.ToString()); SendKeys.Flush();

        //SendKeys.SendWait("{ESC}"); SendKeys.Flush();
        //SendKeys.SendWait(n1.ToString()); SendKeys.Flush();
        //SendKeys.SendWait("{ADD}"); SendKeys.Flush();
        //SendKeys.SendWait(n2.ToString()); SendKeys.Flush();
        //SendKeys.SendWait("{ENTER}"); SendKeys.Flush();

      }
      return result;
    }

    public double Subtract(double n1, double n2)
    {
      double result = n1 - n2;
      if (c != null)
      {
        Process proc = Process.GetProcessesByName("Calc")[0];
        SetForegroundWindow(proc.MainWindowHandle);
        Thread.Sleep(1000);
        SendKeys.SendWait("{ESC}"); SendKeys.Flush();
        SendKeys.SendWait(result.ToString()); SendKeys.Flush();
        //SendKeys.SendWait("{ESC}"); SendKeys.Flush();
        //SendKeys.SendWait(n1.ToString()); SendKeys.Flush();
        //SendKeys.SendWait("{SUBTRACT}"); SendKeys.Flush();
        //SendKeys.SendWait(n2.ToString()); SendKeys.Flush();
        //SendKeys.SendWait("{ENTER}"); SendKeys.Flush();

      }
      return result;
    }

    public double Multiply(double n1, double n2)
    {
      double result = n1 * n2;
      if (c != null)
      {
        Process proc = Process.GetProcessesByName("Calc")[0];
        SetForegroundWindow(proc.MainWindowHandle);
        Thread.Sleep(1000);
        SendKeys.SendWait("{ESC}"); SendKeys.Flush();
        SendKeys.SendWait(result.ToString()); SendKeys.Flush();
        //SendKeys.SendWait("{ESC}"); SendKeys.Flush();
        //SendKeys.SendWait(n1.ToString()); SendKeys.Flush();
        //SendKeys.SendWait("{MULTIPLY}"); SendKeys.Flush();
        //SendKeys.SendWait(n2.ToString()); SendKeys.Flush();
        //SendKeys.SendWait("{ENTER}"); SendKeys.Flush();

      }
      return result;
    }

    public double Divide(double n1, double n2)
    {
      

      if (Math.Abs(n2) > 0.001)
      {
        double result = n1 / n2;
        if (c != null)
        {
          Process proc = Process.GetProcessesByName("Calc")[0];
          SetForegroundWindow(proc.MainWindowHandle);
          Thread.Sleep(1000);
          SendKeys.SendWait("{ESC}"); SendKeys.Flush();
          SendKeys.SendWait(result.ToString()); SendKeys.Flush();
          //SendKeys.SendWait("{ESC}"); SendKeys.Flush();
          //SendKeys.SendWait(n1.ToString()); SendKeys.Flush();
          //SendKeys.SendWait("{DIVIDE}"); SendKeys.Flush();
          //SendKeys.SendWait(n2.ToString()); SendKeys.Flush();
          //SendKeys.SendWait("{ENTER}"); SendKeys.Flush();

        }
        else
        {
          SendKeys.SendWait("{ESC}"); SendKeys.Flush();
          SendKeys.SendWait("0"); SendKeys.Flush();

        }
        return result;
      }
      return 0.0;
    }

    private System.Diagnostics.Process c = null;

    [DllImport("User32.dll")]
    public static extern int SetForegroundWindow(IntPtr point);
    public bool Calc()
    {

      if (c == null)
      {

        try
        {
          c = System.Diagnostics.Process.Start("calc");
          c.WaitForInputIdle();

          IntPtr h = c.MainWindowHandle;
          SetForegroundWindow(h);



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
