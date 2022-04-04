using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public class Provider
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(200)]
        public string? Email { get; set; }
        public IdentificationType identificationType { get; set; }
        [MaxLength(20)]
        public string IdentityDocument { get; set; }
        [MaxLength(200)]
        public string? Description { get; set; }
        [MaxLength(250)]
        public string? Image { get; set; }
        //  relations
        public int? DirectionId { get; set; }
        public virtual Direction Direction { get; set; }
        public int? PhoneId { get; set; }
        public virtual Phone Phone { get; set; }
        public virtual ICollection<Product> Products { get; private set; } = new ObservableCollection<Product>();
        public virtual ICollection<Purchase> Purchases { get; private set; } = new ObservableCollection<Purchase>();
    }
}
