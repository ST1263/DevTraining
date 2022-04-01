using SuplierProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuplierProject.Infra
{
    public interface IBillingAddress
    {
        public List<BillingAddress> GetBillingbysuplierId(int suplierid);
        public void AddBillingAddress(BillingAddress billingAddress);
        public void UpdateBillingAddress(BillingAddress billingAddress);
        public void DeleteBillingAddress(int suplier);
    }
}
