using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string BarCode { get; set; }
        public decimal Price { get; set; }
        public bool IVA { get; set; }
        public string Description { get; set; }
        public string Image { get; set; }
        public int Inventory { get; set; }
        public int AlertInventory { get; set; }
        // data info
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
        public bool DeleteState { get; set; }
        //relations
        public virtual ICollection<Provider> Providers { get; private set; } = new ObservableCollection<Provider>();
        public virtual ICollection<PurchaseProduct> PurchaseProducts { get; private set; } = new ObservableCollection<PurchaseProduct>();
        public virtual ICollection<SaleProduct> SaleProducts { get; private set; } = new ObservableCollection<SaleProduct>();
    }
}
