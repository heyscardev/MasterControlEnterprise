using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public class PurchaseProduct : BaseData
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
        public bool Seller { get; set; }
        // relations
        public int PurchaseId { get; set; }
        public virtual Purchase Purchase { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}
