using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bys.training.teamWings.Models
{
    public class MemberDetail
    {
        public int DeatilId { get; set; }
        public string MemberName { get; set; }
        public string Sex { get; set; }

        public int Age { get; set; }
        public string Specialty { get; set; }
        public string Hobby { get; set; }
        public string FullImg { get; set; }
        public string RelatedImg { get; set; }
    }
}