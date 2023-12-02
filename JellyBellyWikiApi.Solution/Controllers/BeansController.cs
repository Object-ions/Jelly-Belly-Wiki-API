using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JellyBellyWikiApi.Models;

namespace JellyBellyWikiApi.Controllers
{
  [Route("api/[controller]")]
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
    public async Task<ActionResult<IEnumerable<Bean>>> Get(string groupName, string flavorName, string colorGroup, int? sku,  bool? glutenFree, bool? sugarFree, bool? seasonal, bool? kosher)
    {
      IQueryable<Bean> query = _db.Beans.AsQueryable();

      if (!string.IsNullOrEmpty(groupName))
      {
          query = query.Where(entry => entry.GroupName == groupName);
      }
      
      if (!string.IsNullOrEmpty(flavorName))
      {
          query = query.Where(entry => entry.FlavorName == flavorName);
      }

      if (!string.IsNullOrEmpty(colorGroup))
      {
          query = query.Where(entry => entry.ColorGroup == colorGroup);
      }

      if (sku.HasValue)
      {
          query = query.Where(entry => entry.Sku == sku.Value);
      }

      if (glutenFree.HasValue)
      {
          query = query.Where(entry => entry.GlutenFree == glutenFree.Value);
      }

      if (sugarFree.HasValue)
      {
          query = query.Where(entry => entry.SugarFree == sugarFree.Value);
      }

      if (seasonal.HasValue)
      {
          query = query.Where(entry => entry.Seasonal == seasonal.Value);
      }

      if (kosher.HasValue)
      {
          query = query.Where(entry => entry.Kosher == kosher.Value);
      }

      return await query.ToListAsync();
    }

    // GET: api/beans/{id}
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