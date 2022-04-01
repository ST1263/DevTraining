using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SuplierProject.Model
{
    public class Product
    {
        [Key]
        public int productid { get; set; }
        public string productname { get; set; }
        public double produtunit { get; set; }
        public virtual Suplier Suplier { get; set; }
    }
}
