using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuplierProject.Model
{
    public class BillingAddress
    {   
        [Key]
        public int BillId { get; set; }
        public string addressOne { get; set; }
        public string addressTwo { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public int suplierid { get; set; }
        public virtual Suplier Suplier { get; set; }
    }
}
