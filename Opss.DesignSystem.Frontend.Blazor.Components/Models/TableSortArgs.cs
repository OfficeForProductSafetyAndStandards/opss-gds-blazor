using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opss.DesignSystem.Frontend.Blazor.Components.Models
{
    public class TableSortArgs
    {
        public TableSortArgs(string name, string order)
        {
            Order = order;
            Name = name;
        }

        public TableSortArgs(string name) 
        {
            Name = name;
            Order = TableSortOrder.None;
        }

        public string Order { get; set; }

        public string Name { get; set; }
    }

    public static class TableSortOrder { 
        public const string Ascending = "ascending";
        public const string Descending = "descending";
        public const string None = "none";
    }
}
