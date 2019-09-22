using System;
using System.Collections.Generic;
using System.Text;

namespace Plumsail.CommonLib.DataContracts
{
    public class PagedCollection<T>
    {
        public PagedCollection()
        {
            Collection = new List<T>();
            Total = 0;
        }

        public PagedCollection(ICollection<T> collection, int total)
        {
            Collection = collection;
            Total = total;
        }

        public PagedCollection(ICollection<T> collection, int total, int? pageNumber, int? pageSize)
        {
            Collection = collection;
            Total = total;
            PageNumber = pageNumber;
            PageSize = pageSize;
        }

        public ICollection<T> Collection { get; set; }
        public int Total { get; set; }
        public int? PageNumber { get; set; }
        public int? PageSize { get; set; }
    }
}
