using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
  public abstract class Employee
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
      return string.Format("Employee ID: {0} Name: {1}", this.ID, this.Name);
    }

    public string ToStringNew()
    {
      return string.Format($"Employee ID: {this.ID} Name: {this.Name}");
    }
  }

  public class PermanentEmployee : Employee
  {
    public PermanentEmployee(int id, string name) : base(id, name)
    {
    }

    public override decimal CalculateBonus(decimal salary)
    {
      return salary * .1M;
    }
  }

  public class ContractEmployee : PermanentEmployee
  {
    public ContractEmployee(int id, string name) : base(id, name)
    {
    }
    public override decimal CalculateBonus(decimal salary)
    {
      return salary * .05M;
    }
  }
}
