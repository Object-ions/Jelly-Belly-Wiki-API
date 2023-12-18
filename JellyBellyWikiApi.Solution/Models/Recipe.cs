using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json;
using System.Text.Json.Serialization;

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

        // JSON properties are hidden from API responses and used for DB storage
        [JsonIgnore]
        public string IngredientsJson 
        { 
            get => JsonSerializer.Serialize(Ingredients);
            set => Ingredients = value == null ? null : JsonSerializer.Deserialize<string[]>(value);
        }

        [NotMapped]
        public string[] Ingredients { get; set; }

        [JsonIgnore]
        public string Additions1Json 
        { 
            get => JsonSerializer.Serialize(Additions1);
            set => Additions1 = value == null ? null : JsonSerializer.Deserialize<string[]>(value);
        }

        [NotMapped]
        public string[] Additions1 { get; set; }

        [JsonIgnore]
        public string Additions2Json 
        { 
            get => JsonSerializer.Serialize(Additions2);
            set => Additions2 = value == null ? null : JsonSerializer.Deserialize<string[]>(value);
        }

        [NotMapped]
        public string[] Additions2 { get; set; }

        [JsonIgnore]
        public string Additions3Json 
        { 
            get => JsonSerializer.Serialize(Additions3);
            set => Additions3 = value == null ? null : JsonSerializer.Deserialize<string[]>(value);
        }

        [NotMapped]
        public string[] Additions3 { get; set; }

        [JsonIgnore]
        public string DirectionsJson 
        { 
            get => JsonSerializer.Serialize(Directions);
            set => Directions = value == null ? null : JsonSerializer.Deserialize<string[]>(value);
        }

        [NotMapped]
        public string[] Directions { get; set; }

        [JsonIgnore]
        public string TipsJson 
        { 
            get => JsonSerializer.Serialize(Tips);
            set => Tips = value == null ? null : JsonSerializer.Deserialize<string[]>(value);
        }

        [NotMapped]
        public string[] Tips { get; set; }
    }
}