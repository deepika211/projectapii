using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace login_core_apis.Models
{
    public class Student
    { public int sid { get; set; }
        public string sname { get; set; }
         public BOOK bId { get; set; }
        public Teacher tid { get; set; }
    }
}
