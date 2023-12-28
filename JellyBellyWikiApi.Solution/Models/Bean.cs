using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace JellyBellyWikiApi.Models
{
    public class Bean
    {
        public int BeanId { get; set; }

        // GroupName
        [NotMapped]
        public string[] GroupName { get; set; }

        [JsonIgnore]
        public string GroupNameSerialized
        {
            get => GroupName == null ? null : string.Join(", ", GroupName);
            set => GroupName = string.IsNullOrEmpty(value) ? Array.Empty<string>() : value.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
        }
    
        // Ingredients
        [JsonIgnore]
        public string IngredientsSerialized
        {
            get => _ingredientsSerialized;
            set 
            {
                _ingredientsSerialized = value;
                Ingredients = string.IsNullOrEmpty(value) ? Array.Empty<string>() : value.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
            }
        }

        [NotMapped]
        public string[] Ingredients { get; set; }

        private string _ingredientsSerialized; 

        public string FlavorName { get; set; }
        public string Description { get; set; }
        public string ColorGroup { get; set; }
        public string BackgroundColor { get; set; }
        public string ImageUrl { get; set; }
        public bool GlutenFree { get; set; }
        public bool SugarFree { get; set; }
        public bool Seasonal { get; set; }
        public bool Kosher { get; set; }
    }
}
