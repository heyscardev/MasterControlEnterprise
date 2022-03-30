using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public class Direction
    {
        public int Id { get; set; }
        [MaxLength(90)]
        public string Country { get; set; }
        [MaxLength(90)]
        public string State { get; set; }
        [MaxLength(90)]
        public string City { get; set; }
        [MaxLength(90)]
        public string Avenue { get; set; }
        [MaxLength(90)]
        public string Street { get; set; }
        public int PostalCode { get; set; }
        [MaxLength(200)]
        public string? floor { get; set; }
        // data info
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime? DeleteAt { get; set; }
        public bool DeleteState { get; set; }
        //relations
        public virtual ICollection<User> Users { get; private set; } = new ObservableCollection<User>();
        public virtual ICollection<Client> Clients { get; private set; } = new ObservableCollection<Client>();
        public virtual ICollection<Provider> Providers { get; private set; } = new ObservableCollection<Provider>();
    }
}
