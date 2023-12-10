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
    public ActionResult<Pagination<MileStone>> GetGet(int? year, int pageIndex = 1, int pageSize = 10)
    {
      IQueryable<MileStone> query = _db.MileStones.AsQueryable();

      if (year.HasValue)
      {
        query = query.Where(entry => entry.Year == year.Value);
      }

      var pagedResults = PaginationHelper.Paging(query, pageIndex, pageSize);

      return pagedResults;
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