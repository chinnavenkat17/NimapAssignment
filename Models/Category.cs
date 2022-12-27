using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NimapAssignment.Models
{
    public class Category
    {
        public int categoryId { get; set; }
        public string categoryName { get; set; }
        public int CategoryRank { get; set; }
        public string CategoryDesc { get; set; }
    }
}