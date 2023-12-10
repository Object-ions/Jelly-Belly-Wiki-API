using System;
using System.Collections.Generic;
using System.Linq;

namespace JellyBellyWikiApi.Models
{
  public class Pagination<T>
  {
    public int TotalCount { get; set; }
    public int PageSize { get; set; }
    public int CurrentPage { get; set; }
    public int TotalPages => (int)Math.Ceiling((double)TotalCount / PageSize);
    public List<T> Items { get; set; }
  }

  public class PaginationSettings
  {
    public int DefaultPageSize { get; set; }
  }

  public static class PaginationHelper
  {
    public static Pagination<T> Paging<T>(IQueryable<T> query, int pageIndex = 1, int pageSize = 10)
    {
      var result = new Pagination<T>
      {
        TotalCount = query.Count(),
        PageSize = pageSize,
        CurrentPage = pageIndex,
        Items = query.Skip((pageIndex - 1) * pageSize).Take(pageSize).ToList()
      };

      return result;
    }
  }
}