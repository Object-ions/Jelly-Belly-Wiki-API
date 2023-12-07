using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace JellyBellyWikiApi.Models
{
  public class Bean
  {
    public int BeanId { get; set; }

    [NotMapped]
    public string[] GroupName { get; set; }

    public string GroupNameSerialized
    {
      get => GroupName == null ? null : string.Join(", ", GroupName);
      set => GroupName = string.IsNullOrEmpty(value) ? Array.Empty<string>() : value.Split(new[] { ", " }, StringSplitOptions.RemoveEmptyEntries);
    }
    public string FlavorName { get; set; }
    public string Description { get; set; }
    public string ColorGroup { get; set; }
    public string BackgroundColor { get; set; }
    public string ImageUrl { get; set; }
    public string[] Ingredients { get; set; }
    public bool GlutenFree { get; set; }
    public bool SugarFree { get; set; }
    public bool Seasonal { get; set; }
    public bool Kosher { get; set; }
  }
}