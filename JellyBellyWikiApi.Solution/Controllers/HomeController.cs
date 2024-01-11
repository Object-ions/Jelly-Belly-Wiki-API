namespace JellyBellyWikiApi.Controllers
{
  using Microsoft.AspNetCore.Mvc;

  [ApiController]
  public class HomeController : ControllerBase
  {
    [httpGet("/")]
    public IActionResult Get()
    {
      return Redirect("/swagger/index.html");
    }
  }
}