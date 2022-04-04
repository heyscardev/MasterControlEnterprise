using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public class NotificationUser : BaseData
    {
        public int Id { get; set; }
        public NotificationUserState NotificationUserState { get; set; }
        public DateTime? NotifyAt { get; set; }
        public DateTime? ReadAt { get; set; }
       
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
