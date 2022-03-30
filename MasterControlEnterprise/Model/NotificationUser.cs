using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public class NotificationUser
    {
        public int Id { get; set; }
        public NotificationUserState NotificationUserState { get; set; }
        public DateTime? NotifyAt { get; set; }
        public DateTime? ReadAt { get; set; }
        //data info
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
        public bool DeleteState { get; set; }
        //relations
        public int UserId { get; set; }
        public virtual User User { get; set; }
        public int NotificationId { get; set; }
        public virtual Notification Notification { get; set; }
    }
    public enum NotificationUserState
    {
        READ,
        NOTIFY,
        NOREAD,
        EXCLUID,
        DELETE
    }
}
