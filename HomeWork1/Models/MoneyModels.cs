using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HomeWork1.Models
{
    public class MoneyModels
    {
        public Guid Number { get; set; }
        public string Category{ get; set; }
        public DateTime Date { get; set; }
        public Decimal Money { get; set; }
        public string Remarks { get; set; }
    }
}