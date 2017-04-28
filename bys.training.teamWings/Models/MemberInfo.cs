using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace bys.training.teamWings.Models
{
    public class MemberInfo
    {
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public string Hobby { get; set; }
        public string HeadImg { get; set; }
        public string DetailLink { get; set; }
    }
}