using SuplierProject.Infra;
using SuplierProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuplierProject.Service
{
    public class BillingAddressService
    {
        IBillingAddress _service;
        public BillingAddressService(IBillingAddress service)
        {
            _service = service;
        }

        public List<BillingAddress> GetBillingbysuplierId(int SuplierID)
        {
            return _service.GetBillingbysuplierId(SuplierID).ToList();
        }

        public void AddBillingAddress(BillingAddress billingAddress)
        {
            _service.AddBillingAddress(billingAddress);
        }

        public void UpdateBillingAddress(BillingAddress billingAddress)
        {
            _service.UpdateBillingAddress(billingAddress);
        }

        public void DeleteBillingAddress(int suplier)
        {
            _service.DeleteBillingAddress(suplier);
        }
    }
}
