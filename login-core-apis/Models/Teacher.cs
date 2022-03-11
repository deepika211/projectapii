using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace login_core_apis.Models
{
    public class Teacher
    {
        public int tid { get; set; }
        public string tname { get; set; }
        public BOOK bId { get; set; }
    }
}
