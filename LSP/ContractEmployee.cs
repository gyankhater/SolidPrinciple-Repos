using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
  public class ContractEmployee : LSP.IEmployee
  {
    public int ID { get; set; }
    public string Name { get; set; }

    public ContractEmployee(int id, string name)
    {
      this.ID = id;
      this.Name = name;
    }

    public decimal getMinumumSalary()
    {
      return 50000;
    }

  }
}
