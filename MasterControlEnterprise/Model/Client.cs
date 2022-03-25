using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public IdentificationType IdentificationType { get; set; }
        public string IdentityDocument { get; set; }
        public string Email { get; set; }
        public string image { get; set; }
        //data info
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
        public bool DeleteState { get; set; }
        // relations
        public int DirectionId { get; set; }
        public virtual Direction Direction { get; set; }
        public int PhoneId { get; set; }
        public virtual Phone Phone { get; set; }
        public virtual ICollection<Sale> Shops { get; private set; } = new ObservableCollection<Sale>();
    }
}
