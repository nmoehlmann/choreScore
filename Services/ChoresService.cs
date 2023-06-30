namespace choreScore.Services;

public class ChoresService
{
  private readonly ChoresRepository _repo;

  public ChoresService(ChoresRepository repo)
  {
    _repo = repo;
  }

  public List<Chore> GetAllChores()
  {
    List<Chore> chores = _repo.GetAllChores();
    return chores;
  }

  internal Chore createChore(Chore choreData)
  {
    Chore newChore = _repo.createChore(choreData);
    return newChore;
  }

  internal string deleteChore(int choreId)
  {
    Chore chore = _repo.GetById(choreId);
    if (chore == null) throw new Exception($"No chore at id:{choreId}");

    _repo.deleteChore(choreId);
    return $"chore was deleted";
  }

  internal Chore editChore(Chore updateData)
  {
    Chore originalChore = _repo.GetById(updateData.id);
    if (originalChore == null) throw new Exception($"No chore at id:{updateData.id}");

    originalChore.completed = updateData.completed != null ? updateData.completed : originalChore.completed;

    _repo.editChore(updateData);
    return updateData;
  }
}