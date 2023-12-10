using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JellyBellyWikiApi.Models;

namespace JellyBellyWikiApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class FactsController : ControllerBase
  {
    private readonly JellyBellyWikiApiContext _db;
    public FactsController(JellyBellyWikiApiContext db)
    {
      _db = db;
    }

    // GET api/facts
    [HttpGet]
    public ActionResult<Pagination<Fact>> Get(string title, int pageIndex = 1, int pageSize = 10)
    {
      IQueryable<Fact> query = _db.Facts.AsQueryable();

      if (!string.IsNullOrEmpty(title))
      {
        query = query.Where(entry => entry.Title.Contains(title));
      }

      var pagedResults = PaginationHelper.Paging(query, pageIndex, pageSize);

      return pagedResults;
    }

    // GET: api/facts/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<Fact>> GetFact(int id)
    {
      Fact fact = await _db.Facts.FindAsync(id);

      if (fact == null)
      {
        return NotFound();
      }

      return fact;
    }
  }
}