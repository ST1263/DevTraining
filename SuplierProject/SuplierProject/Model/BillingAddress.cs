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
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
        public int SuplierId { get; set; }
        public virtual Suplier Suplier { get; set; }
    }
}
