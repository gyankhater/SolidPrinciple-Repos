using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
  public class PermanentEmployee : LSP.Employee
  {
    public PermanentEmployee(int id, string name) : base(id, name)
    {
    }

    public override decimal CalculateBonus(decimal salary)
    {
      return salary * .1M;
    }

    public override decimal getMinumumSalary()
    {
      return 200000;
    }
  }

}
