using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
 public class TempEmployee : LSP.Employee
  {
    public TempEmployee(int id, string name) : base(id, name)
    {
    }
    public override decimal CalculateBonus(decimal salary)
    {
      return salary * .05M;
    }

    public override decimal getMinumumSalary()
    {
      return 100000;
    }

  }

}
