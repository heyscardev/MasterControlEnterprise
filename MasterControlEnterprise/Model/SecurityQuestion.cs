using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public class SecurityQuestion : BaseData
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Question { get; set; }
        [MaxLength(100)]
        public string Request { get; set; }
        //relations
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
