using System.ComponentModel.DataAnnotations;

namespace choreScore.Models;

public class Chore
{
  public Chore(string name, int Id, int? TimeToComplete, bool? Completed)
  {
    Name = name;
    Id = id;
    TimeToComplete = timeToComplete;
    Completed = completed;
  }

  public string Name { get; set; }
  public int id { get; set; }
  public int? timeToComplete { get; set; }
  public bool? completed { get; set; }
}