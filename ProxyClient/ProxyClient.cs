using ProxyClientx.ServiceReference2;
using System;
using System.Windows.Forms;

namespace ProxyClientx
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
    }

    private void tbValue1_TextChanged(object sender, EventArgs e)
    {

    }

    private void tbValue2_TextChanged(object sender, EventArgs e)
    {

    }

    private double value1;
    private double value2;

    private void btnPlus_Click(object sender, EventArgs e)
    {
      lblOperation.Text = "+";
      double.TryParse(tbValue1.Text, out value1);
      double.TryParse(tbValue2.Text, out value2);
      double result = client.Add(value1, value2);
      lblresult.Text = result.ToString("0.00");
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

    bool CalcIsOn = false;
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

    private void btnExit_Click(object sender, EventArgs e)
    {
      if (CalcIsOn)
      {
        client.CloseCalc();
      }

      client.Close();
      Close();
    }
  }
}
