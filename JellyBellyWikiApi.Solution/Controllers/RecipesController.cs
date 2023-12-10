using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using JellyBellyWikiApi.Models;

namespace JellyBellyWikiApi.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class RecipesController : ControllerBase
  {
    private readonly JellyBellyWikiApiContext _db;
    public RecipesController(JellyBellyWikiApiContext db)
    {
      _db = db;
    }

    // GET api/recipes
    [HttpGet]
    public ActionResult<Pagination<Recipe>> Get(string name, int pageIndex = 1, int pageSize = 10)
    {
      IQueryable<Recipe> query = _db.Recipes.AsQueryable();

      if (!string.IsNullOrEmpty(name))
      {
          query = query.Where(entry => entry.Name.Contains(name));
      }
      var pagedResults = PaginationHelper.Paging(query, pageIndex, pageSize);
      
      return pagedResults;
    }

    // GET: api/recipes/{id}
    [HttpGet("{id}")]
    public async Task<ActionResult<Recipe>> GetRecipe(int id)
    {
      Recipe recipe = await _db.Recipes.FindAsync(id);

      if (recipe == null)
      {
        return NotFound();
      }
      return recipe;
    }
  }
}