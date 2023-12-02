using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JellyBellyWikiApi.Models;

namespace JellyBellyWikiApi.Controllers
{
  [Rout("api/[controller]")]
  [ApiController]
  public class BeansController : ControllerBase
  {
    private readonly JellyBellyWikiApiContext _db;
    public BeansController(JellyBellyWikiApiContext db)
    {
      _db = db;
    }

    // GET api/beans
    [HttpGet]
    public async Task<ActionResult<IEnumerable<Bean>>> Get()
    {
      return await _db.Beans.ToListAsync();
    }

    // GET: api/Beans/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<Bean>> GetBean(int id)
    {
      Bean bean = await _db.Beans.FindAsync(id);

      if (bean == null)
      {
        return NotFound();
      }

      return bean;
    }
  }
}