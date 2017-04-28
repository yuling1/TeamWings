using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bys.training.database.Entities
{
    public class UserInfo
    {
        [Key]
        public int UserId { get; set; }
        public string UserName { get; set; }
        public string HeadImg { get; set; }
        public string DetailLink { get; set; }
        public UserDeatil UserDeatil { get; set; }
    }
}
