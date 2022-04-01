using SuplierProject.Data;
using SuplierProject.Infra;
using SuplierProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuplierProject.Repo
{
    public class BillingAddressRepo : IBillingAddress
    {
        BillingAddressDbContext _context;
        public BillingAddressRepo(BillingAddressDbContext context)
        {
            _context = context;
        }

        public List<BillingAddress> GetBillingbysuplierId(int suplierid)
        {
            return _context.BillingAddress.ToList();
        }

        public void AddBillingAddress(BillingAddress billingAddress)
        {
            _context.Add(billingAddress);
            _context.SaveChanges();
        }

        public void UpdateBillingAddress(BillingAddress billingAddress)
        {
            _context.Update(billingAddress);
            _context.SaveChanges();
        }

        public void DeleteBillingAddress(int suplierid)
        {
            var billingaddress = _context.BillingAddress.Where(s => s.suplierid == suplierid).FirstOrDefault();
            if (billingaddress != null)
            {
                _context.Remove(billingaddress);
                _context.SaveChanges();
            }
        }
    }
}
