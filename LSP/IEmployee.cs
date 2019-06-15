using System;
using System.Collections.Generic;
using System.Text;

namespace LSP
{
  interface IEmployee
  {
    int ID { get; set; }
    string Name { get; set; }
    decimal getMinumumSalary();
    
  }
}
