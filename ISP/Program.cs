using System;

namespace ISP
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Canon canon = new Canon();
      canon.PhotoCopyContent("Photocopy");
      canon.PrintContent(@"MyPath\Test\");
      Console.ReadLine();
    }
  }
}
