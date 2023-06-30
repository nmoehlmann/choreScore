namespace choreScore.Controllers;

[ApiController]
[Route("api/chores")]
public class ChoresController : ControllerBase
{
  private readonly ChoresService _choresService;

  public ChoresController(ChoresService choresService)
  {
    _choresService = choresService;
  }

  [HttpGet]
  public ActionResult<List<Chore>> GetAllChores()
  {
    try
    {
      List<Chore> chores = _choresService.GetAllChores();
      return Ok(chores);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPost]
  public ActionResult<Chore> createChore([FromBody] Chore choreData)
  {
    try
    {
      Chore newChore = _choresService.createChore(choreData);
      return Ok(newChore);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpDelete("{choreId}")]
  public ActionResult<Chore> deleteChore(int choreId)
  {
    try
    {
      string message = _choresService.deleteChore(choreId);
      return Ok(message);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }

  [HttpPut("{choreId}")]
  public ActionResult<Chore> editChore(int choreId, [FromBody] Chore updateData)
  {
    try
    {
      updateData.id = choreId;
      Chore chore = _choresService.editChore(updateData);
      return Ok(chore);
    }
    catch (Exception e)
    {
      return BadRequest(e.Message);
    }
  }
}