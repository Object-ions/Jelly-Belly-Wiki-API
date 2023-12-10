using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JellyBellyWikiApi.Models;

namespace JellyBellyWikiApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class MileStonesController : ControllerBase
  {
    private readonly JellyBellyWikiApiContext _db;
    public MileStonesController(JellyBellyWikiApiContext db)
    {
      _db = db;
    }

    // GET api/mileStones
    [HttpGet]
    public async Task<ActionResult<IEnumerable<MileStone>>> GetGet(int? year)
    {
      IQueryable<MileStone> query = _db.MileStones.AsQueryable();

     if (year.HasValue)
      {
       query = query.Where(entry => entry.Year == year.Value);
      }

      return await query.ToListAsync();
    }

    // GET: api/mileStones/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<MileStone>> GetMileStone(int id)
    {
      MileStone mileStone = await _db.MileStones.FindAsync(id);

      if (mileStone == null)
      {
        return NotFound();
      }

      return mileStone;
    }
  }
}