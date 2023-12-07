using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JellyBellyWikiApi.Models;
using System.Linq;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

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
    public async Task<ActionResult<IEnumerable<Bean>>> Get(string groupName, string flavorName, string colorGroup, int? sku, bool? glutenFree, bool? sugarFree, bool? seasonal, bool? kosher)
    {
      IQueryable<Bean> query = _db.Beans.AsQueryable();

      if (!string.IsNullOrEmpty(flavorName))
      {
        query = query.Where(entry => entry.FlavorName == flavorName);
      }

      if (!string.IsNullOrEmpty(colorGroup))
      {
        query = query.Where(entry => entry.ColorGroup == colorGroup);
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

      var list = await query.ToListAsync();

      if (!string.IsNullOrEmpty(groupName))
      {
        list = list.Where(entry => entry.GroupNameSerialized.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries).Contains(groupName)).ToList();
      }

      return list;
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