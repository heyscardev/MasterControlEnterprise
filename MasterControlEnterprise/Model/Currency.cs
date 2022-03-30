using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterControlEnterprise.Model
{
    public class Currency
    {
        public int Id { get; set; }
        [Column(TypeName ="decimal(12,2)")]
        public decimal Value { get; set; }
        [MaxLength(250)]
        public string? image { get; set; }
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
