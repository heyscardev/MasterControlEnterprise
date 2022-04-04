
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    [Index(nameof(UserName), IsUnique = true)]
    public partial class User : BaseData
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string UserName { get; set; }
        [MaxLength(100)]
        public string FirstName { get; set; }
        [MaxLength(200)]
        public string LastName { get; set; }
        [MaxLength(200)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Password { get; set; }
        public UserType UserType { get; set; }
        public IdentificationType IdentificationType { get; set; }
        [MaxLength(20)]
        public string IdentityDocument { get; set; }
        [MaxLength(250)]
        public string? Image { get; set; }
        //relations
        public int? PhoneId { get; set; }
        public virtual Phone Phone { get; set; }
        public int? DirectionId { get; set; }
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
