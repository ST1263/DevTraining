using CrudRepoAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CrudRepoAPI.Infra
{
    public interface ICustomer
    {
       public List<Customer> GetCustomers();
        public Customer GetCustomer(int CustId);
    /*    public void DeleteCustomer(int CustId);*/
        public void Create(Customer customer);
       /* public void Update(Customer customer);*/

    }
}
