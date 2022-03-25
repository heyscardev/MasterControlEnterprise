using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public class Currency
    {
        public int Id { get; set; }
        public decimal Value { get; set; }
        public string image { get; set; }
        //data info
        public DateTime CreatedAt { get; set; }
        public DateTime UpdateAt { get; set; }
    }
    public enum CurrencyType
    {
        DOLLAR,
        BOLIVAR,
        OTRO
    }
}
