using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CrudRepoAPI.Model
{
    public class Customer
    {
        [Key]
        public int CustId { get; set; }
        public string CustName { get; set; }
        public string CustLName { get; set; }
    }
}
