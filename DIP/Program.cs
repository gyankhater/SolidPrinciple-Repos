using System;

namespace DIP
{
  class Program
  {
    static void Main(string[] args)
    {
      
    }
  }

  public interface IrepositoryLayer
  {
    void Save(Object details);
  }

  public class DataAccessLayer : IrepositoryLayer
  {
    public void Save(object details)
    {
      Console.WriteLine("Detail Saved!");
    }
  }

  public class BusinessLayer
  {
    private readonly IrepositoryLayer DAL;

    public BusinessLayer(IrepositoryLayer repositorylayer)
    {
      DAL = repositorylayer;
    }

    public void Save(Object details)
    {
      DAL.Save(details);
    }
  }

}