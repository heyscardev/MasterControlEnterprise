using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public class Product: BaseData
    {
        public int Id { get; set; }
        [MaxLength(100)]
        public string Name { get; set; }
        [MaxLength(50)]
        public string BarCode { get; set; }
        [Column(TypeName ="decimal(12,2)")]
        public decimal Price { get; set; }
        public bool IVA { get; set; }
        [MaxLength(200)]
        public string? Description { get; set; }
        [MaxLength(250)]
        public string? Image { get; set; }
        public int Inventory { get; set; }
        public int? AlertInventory { get; set; }
        
        //relations
        public virtual ICollection<Provider> Providers { get; private set; } = new ObservableCollection<Provider>();
        public virtual ICollection<PurchaseProduct> PurchaseProducts { get; private set; } = new ObservableCollection<PurchaseProduct>();
        public virtual ICollection<SaleProduct> SaleProducts { get; private set; } = new ObservableCollection<SaleProduct>();
    }
}
