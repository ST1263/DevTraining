using SuplierProject.Data;
using SuplierProject.Infra;
using SuplierProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuplierProject.Repo
{
    public class SuplierRepo : ISuplier
    {
        SuplierDbContext _context;
        public SuplierRepo(SuplierDbContext context)
        {
            _context = context;
        }

        public List<Suplier> GetSupliers()
        {
            // return _context.Suplier.ToList();
            var result = (from s in _context.Suplier

                          select new Suplier
                          {
                              suplierid = s.suplierid,
                              supliername = s.supliername,
                              Products = s.Products,
                              BillingAddress = s.BillingAddress
                              


                          }).ToList();
            return result;
        }

        public Suplier GetSuplier(int suplierid)
        {
            return _context.Suplier.FirstOrDefault(e => e.suplierid == suplierid);
        }

        public void AddSuplier(Suplier suplier)
        {
            _context.Add(suplier);
            _context.SaveChanges();
        }

        public void UpdateSuplier(Suplier suplier)
        {
            _context.Update(suplier);
            _context.SaveChanges();
        }

        public void DeleteSuplier(int suplier)
        {
            var supplier = _context.Suplier.Where(s => s.suplierid == suplier).FirstOrDefault();
            if (supplier != null)
            {
                _context.Remove(supplier);
                _context.SaveChanges();
            }
        }
    }
}
