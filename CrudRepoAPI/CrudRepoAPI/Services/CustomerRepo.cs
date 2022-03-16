using CrudRepoAPI.Data;
using CrudRepoAPI.Infra;
using CrudRepoAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CrudRepoAPI.Services
{
    public class CustomerRepo : ICustomer
    {
        public databaseContext _context;

        public CustomerRepo(databaseContext context)
        {
            _context = context;
        }
        public List<Customer> GetCustomers()
        {
            return _context.Customer.ToList();
        }

        public Customer GetCustomer(int CustId)
        {
            return _context.Customer.FirstOrDefault(f => f.CustId == f.CustId);
        }
        /*public void DeleteCustomer(int CustId)
        {
            var deleteid = _context.Customer.Where(f => f.CustId == CustId).FirstOrDefault();
            _context.Customer.Remove(deleteid);
            _context.SaveChanges();

        }*/
        public void Create(Customer customer)
        {
            _context.Add(customer);
            _context.SaveChanges();
        }
       /* public void Update(Customer customer)
        {
            _context.Update(customer);
            _context.SaveChanges();
        }*/

    }
}
