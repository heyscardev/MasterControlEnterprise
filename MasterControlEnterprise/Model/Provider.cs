using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public class Provider
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public IdentificationType identificationType { get; set; }
        public string IdentityDocument { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        //data info
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
        public bool DeleteState { get; set; }
        //  relations
        public int DirectionId { get; set; }
        public virtual Direction Direction { get; set; }
        public int PhoneId { get; set; }
        public virtual Phone Phone { get; set; }
        public virtual ICollection<Product> Products { get; private set; } = new ObservableCollection<Product>();
        public virtual ICollection<Purchase> Purchases { get; private set; } = new ObservableCollection<Purchase>();
    }
}
