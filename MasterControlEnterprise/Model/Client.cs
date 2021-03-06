using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public class Client : BaseData
    {
        public int Id { get; set; }
        [MaxLength(80)]
        public string Name { get; set; }
        [MaxLength(80)]
        public string LastName { get; set; }
        public IdentificationType IdentificationType { get; set; }
        [MaxLength(20)]
        public string IdentityDocument { get; set; }
        [MaxLength(200)]
        public string? Email { get; set; }
        [MaxLength(250)]
        public string? image { get; set; }
        // relations
        public int? DirectionId { get; set; }
        public virtual Direction Direction { get; set; }
        public int? PhoneId { get; set; }
        public virtual Phone Phone { get; set; }
        public virtual ICollection<Sale> Shops { get; private set; } = new ObservableCollection<Sale>();
    }
}
