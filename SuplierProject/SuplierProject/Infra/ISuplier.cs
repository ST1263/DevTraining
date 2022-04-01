using SuplierProject.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuplierProject.Infra
{
    public interface ISuplier
    {
        public List<Suplier> GetSupliers();
        public Suplier GetSuplier(int suplierid);   
        public void AddSuplier(Suplier suplier);
        public void UpdateSuplier(Suplier suplier);
        public void DeleteSuplier(int suplier);
    }
}