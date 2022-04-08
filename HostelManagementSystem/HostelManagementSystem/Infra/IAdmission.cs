using HostelManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementSystem.Infra
{
    public interface IAdmission
    {
        public List<Admission> GetAdmissions();
        public Admission GetAdmissionById(int AdmissionId);
        public void AddAdmission(Admission admission);
        public void UpdateAdmission(Admission admission);
        public void DeleteAdmission(int admission);
    }
}
