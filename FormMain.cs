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
  public partial class FormMain : Form
  {
    private Calculation _calculation = new Calculation();
    public FormMain()
    {
      InitializeComponent();
    }

    private void buttonCalculate_Click(object sender, EventArgs e)
    {
      _calculation.Value = numericUpDownSecondArgument.Value;
    }

    private void buttonCreatAddForm_Click(object sender, EventArgs e)
    {
      FormCalculation form = new FormAdd(numericUpDownFirstArgument.Value, _calculation);
      form.Show(this);
    }

    private void buttonCreatSubstractForm_Click(object sender, EventArgs e)
    {
      FormCalculation form = new FormSubstract(numericUpDownFirstArgument.Value, _calculation);
      form.Show(this);
    }
  }
}
