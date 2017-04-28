using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bys.training.teamWings.Dto
{
    public class UserInfoDto
    {

        public int UserId { get; set; }
        public string UserName { get; set; }
        public string HeadImg { get; set; }
        public string DetailLink { get; set; }
        public UserDeatilDto UserDeatilDto { get; set; }
    }
}
