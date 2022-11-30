using System.Collections.Generic;
using System.Linq;

namespace Application.Common.Models
{
    public class Result<T>
    {
        public string Code { get; set; }
        public string Service { get; set; }
        public T Data { get; set; }
    }
}
