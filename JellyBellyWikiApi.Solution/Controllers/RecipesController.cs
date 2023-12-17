using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JellyBellyWikiApi.Models;

namespace JellyBellyWikiApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class CombinationsController : ControllerBase
  {
    private readonly JellyBellyWikiApiContext _db;
    public CombinationsController(JellyBellyWikiApiContext db)
    {
      _db = db;
    }

    // GET api/combinations
    [HttpGet]
    public ActionResult<Pagination<Combination>> Get(string name, int pageIndex = 1, int pageSize = 10)
    {
      IQueryable<Combination> query = _db.Combinations.AsQueryable();

      if (!string.IsNullOrEmpty(name))
      {
          query = query.Where(entry => entry.Name.Contains(name));
      }
      var pagedResults = PaginationHelper.Paging(query, pageIndex, pageSize);
      
      return pagedResults;
    }

    // GET: api/combinations/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<Combination>> GetCombination(int id)
    {
      Combination combination = await _db.Combinations.FindAsync(id);

      if (combination == null)
      {
        return NotFound();
      }
      return combination;
    }
  }
}