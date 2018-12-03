using nsProxyClient.ServiceReference2;
using System;
using System.Threading;
using System.Windows.Forms;

namespace nsProxyClient
{
  public partial class ProxyClient : Form
  {
    private CalculatorClient client = new CalculatorClient();

    public ProxyClient()
    {
      InitializeComponent();
    }

    private void ProxyClient_Load(object sender, EventArgs e)
    {
      tbValue1.Text = "";
      tbValue2.Text = "";
      lblOperation.Text = "";
      lblresult.Text = "";
      ValidateValues();
    }

    private void tbValue1_TextChanged(object sender, EventArgs e)
    {
      ValidateValues();
    }

    private void tbValue2_TextChanged(object sender, EventArgs e)
    {
      ValidateValues();
    }

    private void ValidateValues()
    {
      if (int.TryParse(tbValue1.Text, out int x) && int.TryParse(tbValue2.Text, out x))
      {
        btnPlus.Enabled = true;
        btnSubtract.Enabled = true;
        btnMultiply.Enabled = true;
        btnDivide.Enabled = true;
      }
      else
      {
        btnPlus.Enabled = false;
        btnSubtract.Enabled = false;
        btnMultiply.Enabled = false;
        btnDivide.Enabled = false;
      }
    }
    private double value1;
    private double value2;

    private void btnPlus_Click(object sender, EventArgs e)
    {
      lblOperation.Text = "+";
      double.TryParse(tbValue1.Text, out value1);
      double.TryParse(tbValue2.Text, out value2);
      double result = client.Add(Convert.ToDouble(value1), Convert.ToDouble(value2));
      lblresult.Text = result.ToString();
    }

    private void btnSubtract_Click(object sender, EventArgs e)
    {
      lblOperation.Text = "-";
      double.TryParse(tbValue1.Text, out value1);
      double.TryParse(tbValue2.Text, out value2);
      double result = client.Subtract(value1, value2);
      lblresult.Text = result.ToString("0.00");
    }

    private void btnMultiply_Click(object sender, EventArgs e)
    {
      lblOperation.Text = "*";
      double.TryParse(tbValue1.Text, out value1);
      double.TryParse(tbValue2.Text, out value2);
      double result = client.Multiply(value1, value2);
      lblresult.Text = result.ToString("0.00");
    }

    private void btnDivide_Click(object sender, EventArgs e)
    {
      lblOperation.Text = "/";
      double.TryParse(tbValue1.Text, out value1);
      double.TryParse(tbValue2.Text, out value2);
      double result = client.Divide(value1, value2);
      lblresult.Text = result.ToString("0.00");
    }

    private bool CalcIsOn = false;
    private void btnCalc_Click(object sender, EventArgs e)
    {
      if (CalcIsOn)
      {
        client.CloseCalc();
        CalcIsOn = false;
      }
      else
      {
        CalcIsOn = client.Calc();
      }

    }

    private void CloseApplication()
    {
      if (CalcIsOn)
      {
        client.CloseCalc();
        Thread.Sleep(1000);
      }

      client.Close();
      Thread.Sleep(1000);
      Environment.Exit(0);
    }

    private void btnExit_Click(object sender, EventArgs e)
    {
      CloseApplication();
    }

    private void ProxyClient_FormClosing(object sender, FormClosingEventArgs e)
    {
      CloseApplication();
    }
  }
}
