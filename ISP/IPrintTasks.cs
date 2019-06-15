using System;
using System.Collections.Generic;
using System.Text;

namespace ISP
{
  interface IPrintSCanContent
  {
    void PrintContent(string content);
    void ScanContent(string content);
    void PhotoCopyContent(string content);
  }

  interface IFaxContent
  {
    void FaxContent(string content);
  }

  interface IPrintDuplex
  {
    void PrintDuplexContent(string content);
  }

}
