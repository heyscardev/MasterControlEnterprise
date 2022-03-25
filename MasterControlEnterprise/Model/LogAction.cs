using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public class LogAction
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public LogActionType LogActionType { get; set; }
        //data info
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
        public bool DeleteState { get; set; }
        //relations
        public int UserId { get; set; }
        public virtual User User { get; set; }
    }
    public enum LogActionType
    {
        LOGIN,
        LOGOUT,
        CREATE,
        UPDATE,
        DELETE,
        MASTERDELETE,
        OTHER
    }
}
