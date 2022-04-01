using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuplierProject.Model
{
    public class Suplier
    {
        [Key]
        public int suplierid { get; set;}
        public string supliername { get; set;}
        public virtual BillingAddress BillingAddress { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
