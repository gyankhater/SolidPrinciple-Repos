using System;

namespace LSP
{
  class Program
  {
    static void Main(string[] args)
    {
      Employee emp = new PermanentEmployee(1,"Gyan");
      Console.WriteLine($"{emp.ToString()} and your salary is {emp.CalculateBonus(200000)}");
      Employee empCont = new ContractEmployee(2, "Contract Emp");
      Console.WriteLine($"{empCont.ToString()} and your salary is {empCont.CalculateBonus(200000)}");
      Console.ReadLine();
    }
  }
}