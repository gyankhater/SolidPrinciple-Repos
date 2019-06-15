using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
  class Canon : IPrintSCanContent
  {
    public void PhotoCopyContent(string content)
    {
      Console.WriteLine($"{content} done");   
    }

    public void PrintContent(string content)
    {
      Console.WriteLine($"MyPath is: {content}");
    }

    public void ScanContent(string content)
    {
      Console.WriteLine("Scan done");
    }
  }
}
