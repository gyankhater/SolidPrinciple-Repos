using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
  public abstract class Employee: LSP.IEmployee, LSP.IEmployeeBonus
  {
    public int ID { get; set; }
    public string Name { get; set; }
      
    public Employee()
    {
    }
    public Employee(int id, string name)
    {
      this.ID = id;
      this.Name = name;
    }

    public abstract decimal CalculateBonus(decimal salary);
       
    public override string ToString()
    {
      return string.Format($"Employee ID: {this.ID} Name: {this.Name}");
    }

    public abstract decimal getMinumumSalary();
  }

}
  