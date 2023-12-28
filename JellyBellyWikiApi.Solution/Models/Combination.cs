using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json.Serialization;

namespace JellyBellyWikiApi.Models
{
    public class Combination
    {
        public int CombinationId { get; set; }
        public string Name { get; set; }
    
        // Tag
        [JsonIgnore]
        public string TagSerialized
        {
            get => _tagSerialized;
            set
            {
                _tagSerialized = value;
                Tag = string.IsNullOrEmpty(value) 
                    ? Array.Empty<string>() 
                    : value.Split(new[] { "," }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(tag => tag.Trim())
                        .ToArray();
            }
        }

        [NotMapped]
        public string[] Tag { get; set; }

        private string _tagSerialized;
    }
}
