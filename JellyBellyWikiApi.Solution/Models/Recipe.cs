using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
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

        // Ingredients
        [JsonIgnore]
        public string IngredientsSerialized { get; set; }

        [NotMapped]
        public string[] Ingredients 
        {
            get => string.IsNullOrEmpty(IngredientsSerialized) ? Array.Empty<string>() : IngredientsSerialized.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            set => IngredientsSerialized = string.Join(", ", value);
        }

        // Additions1
        [JsonIgnore]
        public string Additions1Serialized { get; set; }

        [NotMapped]
        public string[] Additions1 
        {
            get => string.IsNullOrEmpty(Additions1Serialized) ? Array.Empty<string>() : Additions1Serialized.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            set => Additions1Serialized = string.Join(", ", value);
        }

        // Additions2
        [JsonIgnore]
        public string Additions2Serialized { get; set; }

        [NotMapped]
        public string[] Additions2 
        {
            get => string.IsNullOrEmpty(Additions2Serialized) ? Array.Empty<string>() : Additions2Serialized.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            set => Additions2Serialized = string.Join(", ", value);
        }

        // Additions3
        [JsonIgnore]
        public string Additions3Serialized { get; set; }

        [NotMapped]
        public string[] Additions3 
        {
            get => string.IsNullOrEmpty(Additions3Serialized) ? Array.Empty<string>() : Additions3Serialized.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            set => Additions3Serialized = string.Join(", ", value);
        }

        // Directions
        [JsonIgnore]
        public string DirectionsSerialized { get; set; }

        [NotMapped]
        public string[] Directions 
        {
            get => string.IsNullOrEmpty(DirectionsSerialized) ? Array.Empty<string>() : DirectionsSerialized.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            set => DirectionsSerialized = string.Join(", ", value);
        }

        // Tips
        [JsonIgnore]
        public string TipsSerialized { get; set; }

        [NotMapped]
        public string[] Tips 
        {
            get => string.IsNullOrEmpty(TipsSerialized) ? Array.Empty<string>() : TipsSerialized.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            set => TipsSerialized = string.Join(", ", value);
        }
    }
}
