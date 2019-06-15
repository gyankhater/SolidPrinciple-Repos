using System;
using System.Collections.Generic;

namespace LSP
{
  class Program
  {
    static void Main(string[] args)
    {
      List<LSP.Employee> employees = new List<Employee>();
      employees.Add(new PermanentEmployee(1, "John"));
      employees.Add(new TempEmployee(2, "Jason"));
      //employees.Add(new ContractEmployee(3, "Mike"));

      foreach (var employee in employees)
      {
        Console.WriteLine($"Emp:{employee.Name} , Bonus: {employee.CalculateBonus(200000)} , MinSalary: {employee.getMinumumSalary()}");
        employee.ToString();
      }

      Console.WriteLine();

      List<IEmployee> emp = new List<IEmployee>();
      emp.Add(new PermanentEmployee(1, "John"));
      emp.Add(new TempEmployee(2, "Jason"));
      emp.Add(new ContractEmployee(3, "Mike"));

      foreach (var e in emp)
      {
        Console.WriteLine($"Emp:{e.Name} , MinSalary: {e.getMinumumSalary()}");
        e.ToString();
      }
      Console.ReadLine();
    }
  }
}
