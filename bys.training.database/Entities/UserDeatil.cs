using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bys.training.database.Entities
{
    public class UserDeatil
    {
        [Key]
        public int DeatilId { get; set; }
        public string UserName { get; set; }
        public string Sex { get; set; }

        public int Age { get; set; }
        public string Specialty { get; set; }
        public string Hobby { get; set; }
        public string FullImg { get; set; }
        public string RelatedImg { get; set; }
    }
}
