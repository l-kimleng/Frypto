using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Frypto.Core.Models
{
    public class QueryResult<T>
    {
        public int TotalItem { get; set; }
        public IList<T> Items { get; set; }
    }
}
