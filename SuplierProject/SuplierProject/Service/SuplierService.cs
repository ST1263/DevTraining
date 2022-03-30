using SuplierProject.Infra;
using SuplierProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuplierProject.Service
{
    public class SuplierService
    {
        ISuplier _service;
        public SuplierService(ISuplier service)
        {
            _service = service;
        }

        public List<Suplier> GetSupliers()
        {
            return _service.GetSupliers().ToList();
        }

        public Suplier GetSuplier(int SuplierId)
        {
            return _service.GetSuplier(SuplierId);
        }

        public void AddSuplier(Suplier suplier)
        {
            _service.AddSuplier(suplier);
        }

        public void UpdateSuplier(Suplier suplier)
        {
            _service.UpdateSuplier(suplier);
        }

        public void DeleteSuplier(int suplier)
        {
            _service.DeleteSuplier(suplier);
        }
    }
}
