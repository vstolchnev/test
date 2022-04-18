using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsExample2019_643
{
  public class Calculation
  {
    public delegate void dProcessValue(decimal parValue);
    public event dProcessValue ProcessValue = null;
    private decimal _value;
    public decimal Value
    {
      get { return _value; }
      set
      {
        _value = value;
          ProcessValue?.Invoke(_value);
      }
    }
    protected void CallProcessValue(decimal parValue)
    {
      ProcessValue?.Invoke(parValue);
    }
  }
}
