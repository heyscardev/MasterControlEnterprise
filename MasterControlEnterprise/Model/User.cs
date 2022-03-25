using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public partial class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public UserType UserType { get; set; }
        public IdentificationType IdentificationType { get; set; }
        public string IdentityDocument { get; set; }
        public string Image { get; set; }
        // data info
        public DateTime CreatedAt   { get; set; }
        public DateTime UpdateAt    { get; set; }
        public DateTime DeleteAt { get; set; }
        public bool DeleteState { get; set; } 
        //relations
        public int PhoneId { get; set; }
        public virtual Phone Phone { get; set; }
        public int DirectionId { get; set; }
        public virtual Direction Direction { get; set; }
        public virtual ICollection<SecurityQuestion> SecurityQuestions { get; private set; } = new ObservableCollection<SecurityQuestion>();
        public virtual ICollection<LogAction> LogActions { get; private set; } = new ObservableCollection<LogAction>();
        public virtual ICollection<Sale> Sales { get; private set; } = new ObservableCollection<Sale>();
        public virtual ICollection<NotificationUser> Notificatio { get; private set; } = new ObservableCollection<NotificationUser>();
    }
    public enum UserType
    {
    ADMIN,
    MANAGER,
    SELLER
    }
}
