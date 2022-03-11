using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace login_core_apis.Models
{
    public class Issue
    {
        public int issueId { get; set; }
        public DateTime doi { get; set; }
        public DateTime dor { get; set; }
        public DateTime returnedBy { get; set; }
        public Student sid { get; set; }
        public Teacher tid { get; set; }
        public BOOK bId { get; set; }
    }
}
