using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public class Purchase : BaseData
    {
        public int Id { get; set; }
        public PurchaseState PurchaseState { get; set; }
        public DateTime? DateShop {get; set; }
        public DateTime? dateRecived { get; set; }
        [MaxLength(200)]
        public string? Description { get; set; }
       
        //relation
        public int ProviderId { get; set; }
        public virtual Provider Provider { get; set; }
        public virtual ICollection<PurchaseProduct> PurchaseProducts { get; private  set; } = new ObservableCollection<PurchaseProduct>();
    }
    public enum PurchaseState
    {
        PAIDORDER,//PAGADO MAS NO ENTREGADO
        PAID, // PAGADO Y ENTREGADO
        ORDER, //ORDENADO NO PAGADO NI ENTREGADO
        PENDING,//ENTREGADO MAS NO PAGADO
        CANCELED,//CANCELADO 
    }
}
