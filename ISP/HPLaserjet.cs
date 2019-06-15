using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
  class HPLaserjet : IPrintSCanContent, IPrintDuplex, IFaxContent
  {
    public void FaxContent(string content)
    {
      Console.WriteLine("Fax done");
    }

    public void PhotoCopyContent(string content)
    {
      Console.WriteLine("Photocopy done");        
    }

    public void PrintContent(string content)
    {
      Console.WriteLine("Print done");      
    }

    public void PrintDuplexContent(string content)
    {
      Console.WriteLine("Print duplex content");      
    }

    public void ScanContent(string content)
    {
      Console.WriteLine("Scan done");      
    }
  }
}
