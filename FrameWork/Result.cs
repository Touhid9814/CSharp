using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SMS.Framework
{
    public class Result<T>
    {
        public Result()
        {
            Messages = new List<string>();
        }
        public T Data { get; set; }
        public bool HasError;
        public bool HasWarning;
        public List<string> Messages { get; set; } 
    }
}
