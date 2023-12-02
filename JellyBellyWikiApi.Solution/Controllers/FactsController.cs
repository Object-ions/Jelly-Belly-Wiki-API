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
    public async Task<ActionResult<IEnumerable<Fact>>> Get(string title, string description)
    {
      IQueryable<Fact> query = _db.Facts.AsQueryable();

      if (!string.IsNullOrEmpty(title))
      {
          query = query.Where(entry => entry.Title == title);
      }
      
      if (!string.IsNullOrEmpty(description))
      {
          query = query.Where(entry => entry.Description == description);
      }

      return await query.ToListAsync();
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