using Microsoft.AspNetCore.Mvc;

namespace JellyBellyWikiApi.Controllers
{
  [ApiController]
  public class HomeController : ControllerBase
  {
    [HttpGet("/")]
    public IActionResult Get()
    {
      return Redirect("/swagger/index.html");
    }
  }
}