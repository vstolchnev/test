using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsExample2019_643
{
  public abstract partial class FormCalculation : Form
  {
    private Calculation _calculation = null;
    private decimal _firstArgument = 0;
    protected FormCalculation(decimal parFirstArgument, Calculation parCalculation, string parOperand)
    {
      _calculation = parCalculation;
      _calculation.ProcessValue += ProcessValue;
      InitializeComponent();
      _firstArgument = parFirstArgument;
      labelOperand.Text = parOperand;
      textBoxFirstArgument.Text = parFirstArgument.ToString();
    }

    private void ProcessValue(decimal parValue)
    {
      textBoxSecondArgument.Text = parValue.ToString();
      textBoxResult.Text = Calculate(_firstArgument, parValue).ToString();
      //Calculate(parValue);
    }

    protected abstract decimal Calculate(decimal parFirstArgument, decimal parSecondArgument);
  }
}
