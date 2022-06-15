using System;
using System.Collections.Generic;
using System.Text;

namespace ByeBikari.Framework.Paged
{
    public interface IPagedList<T>
    {
        List<T> DataList { get; set; }
        int PageIndex { get; set; }
        int PageSize { get; set; }
        int TotalCount { get; set; }
        int TotalPages { get; set; }
        bool HasPreviousPage { get; }
        bool HasNextPage { get; }
    }
}
