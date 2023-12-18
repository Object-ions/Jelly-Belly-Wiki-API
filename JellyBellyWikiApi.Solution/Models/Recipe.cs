using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;

namespace JellyBellyWikiApi.Models
{
  public class Recipe
  {
    public int RecipeId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string PrepTime { get; set; }
    public string CookTime { get; set; }
    public string TotalTime { get; set; }
    public string MakingAmount { get; set; }
    public string ImageUrl { get; set; }
    public string[] Ingredients { get; set; }

    public string Additions1Json 
    { 
      get => JsonSerializer.Serialize(Additions1);
      set => Additions1 = JsonSerializer.Deserialize<string[]>(value);
    }

    [NotMapped]
    public string[] Additions1 { get; set; }

    public string Additions2Json 
    { 
      get => JsonSerializer.Serialize(Additions2);
      set => Additions2 = JsonSerializer.Deserialize<string[]>(value);
    }

    [NotMapped]
    public string[] Additions2 { get; set; }

    public string Additions3Json 
    { 
      get => JsonSerializer.Serialize(Additions3);
      set => Additions3 = JsonSerializer.Deserialize<string[]>(value);
    }

    [NotMapped]
    public string[] Additions3 { get; set; }

    public string[] Directions { get; set; }
    public string[] Tips { get; set; }
  }
}