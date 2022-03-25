using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public class Phone
    {
        public int Id { get; set; }
        public int Cod_Country  { get; set; }
        public int PhoneNumber { get; set; }
        public bool WhatsApp { get; set; }
        //data info
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
        public bool DeleteState { get; set; }
        //relations
        public virtual ICollection<User> Users { get; private set; } = new ObservableCollection<User>();
        public virtual ICollection<Client> Clients { get; private set; } = new ObservableCollection<Client>();
        public virtual ICollection<Provider> Providers { get; private set; } = new ObservableCollection<Provider>();
    }
}
