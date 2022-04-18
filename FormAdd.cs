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
  public partial class FormAdd : FormCalculation
  {
    public FormAdd(decimal parFirstArgument, Calculation parCalculation) : base(parFirstArgument, parCalculation, "+")
    {
      // sdsfsfdsfsfs
      InitializeComponent();
      this.ClientSize = new System.Drawing.Size(406, 108);
    }
    protected override decimal Calculate(decimal parFirstArgument, decimal parSecondArgument)
    {
      // Комментарий второго разработчика
      return parFirstArgument + parSecondArgument;
    }
  }
}
