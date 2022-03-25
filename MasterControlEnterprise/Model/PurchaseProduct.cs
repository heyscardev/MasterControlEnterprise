﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public class PurchaseProduct
    {
        public int Id { get; set; }
        public decimal Cost { get; set; }
        public int Quantity { get; set; }
        public bool Seller { get; set; }
        // data info
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
        public DateTime DeleteAt { get; set; }
        public bool DeleteState { get; set; }
        // relations
        public int PurchaseId { get; set; }
        public virtual Purchase Purchase { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }

    }
}
