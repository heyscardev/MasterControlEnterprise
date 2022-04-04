using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public class LogAction : BaseData
    {
        public int Id { get; set; }
        [MaxLength(250)]
        public string? Description { get; set; }
        public LogActionType LogActionType { get; set; }
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
