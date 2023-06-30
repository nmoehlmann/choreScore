namespace choreScore.Repositories;

public class ChoresRepository
{
  private List<Chore> dbChores;

  public ChoresRepository()
  {
    this.dbChores = new List<Chore> { };
    dbChores.Add(new Chore("clean room", 1, 30, false));
    dbChores.Add(new Chore("wash dishes", 2, 20, false));
    dbChores.Add(new Chore("mow lawn", 3, 60, false));
  }


  internal List<Chore> GetAllChores()
  {
    return dbChores;
  }
  internal Chore createChore(Chore choreData)
  {
    int lastId = dbChores[dbChores.Count - 1].id;
    choreData.id = lastId + 1;

    dbChores.Add(choreData);
    return choreData;
  }

  internal Chore GetById(int choreId)
  {
    Chore chore = dbChores.Find(c => c.id == choreId);
    return chore;
  }

  internal void deleteChore(int choreId)
  {
    Chore chore = dbChores.Find(c => c.id == choreId);
    dbChores.Remove(chore);
  }

  internal void editChore(Chore updateData)
  {
    Chore chore = GetById(updateData.id);
    chore = updateData;
  }
}