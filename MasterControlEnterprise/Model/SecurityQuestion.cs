using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public class SecurityQuestion
    {
        int Id { get; set; }
        public string Question { get; set; }
        public string Request { get; set; }
        //data info
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
        public bool DeleteState { get; set; }
        //relations
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
}
