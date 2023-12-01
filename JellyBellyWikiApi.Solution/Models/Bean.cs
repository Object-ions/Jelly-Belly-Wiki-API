using System.Collections.Generic;

namespace JellyBellyWikiApi.Models
{
    public class Bean
    {
        public int BeanId { get; set; }
        public int Sku { get; set; }
        public string GroupName { get; set; }
        public string FlavorName { get; set; }
        public string Description { get; set; }
        public string ColorGroup { get; set; }
        public string BackgroundColor { get; set; }
        public string ImageUrl { get; set; }
        public List<string> Ingredients { get; set; }
        public List<string> Mixes { get; set; }
        public bool GlutenFree { get; set; }
        public bool SugarFree { get; set; }
        public bool Seasonal { get; set; }
        public bool Kosher { get; set; }
    }
}