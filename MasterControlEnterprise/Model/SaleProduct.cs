using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public class SaleProduct
    {
        public int Id { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal Price { get; set; }
        [Column(TypeName = "decimal(12,2)")]
        public decimal Impuesto { get; set; }
        public int Quantity { get; set; }
        // data info
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
        public bool DeleteState { get; set; }
        // relations
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
        public int SaleId { get; set; }
        public virtual Sale Sale { get; set; }
    }
}
