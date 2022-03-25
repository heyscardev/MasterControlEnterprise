using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public class Sale
    {
        public int Id { get; set; }
        public SaleState SaleState { get; set; }
        //data info
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
        public bool DeleteState { get; set; }
        // relations
        public int ClientId { get; set; }
        public virtual Client Client { get; set; }
        public int userId { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<SaleProduct> SaleProducts { get; private set; } = new ObservableCollection<SaleProduct>();
    }
    public enum SaleState
    {
        PAID,
        PENDING,
        CANCELED
    }
}
