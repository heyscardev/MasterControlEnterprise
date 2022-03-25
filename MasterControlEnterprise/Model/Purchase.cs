using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public class Purchase
    {
        public int Id { get; set; }
        public PurchaseState PurchaseState { get; set; }
        public DateTime DateShop {get; set; }
        public DateTime dateRecived { get; set; }
        public string Description { get; set; }
        // data info
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
        public bool DeleteState { get; set; }
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
