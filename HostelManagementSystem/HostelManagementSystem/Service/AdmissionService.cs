using HostelManagementSystem.Infra;
using HostelManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementSystem.Service
{
    public class AdmissionService
    {
        IAdmission _service;
        public AdmissionService(IAdmission service)
        {
            _service = service;
        }

        public List<Admission>GetAdmissions()
        {
            return _service.GetAdmissions().ToList();
        }

        public Admission GetAdmissionById(int AdmissionId)
        {
            return _service.GetAdmissionById(AdmissionId);
        }

        public void AddAdmission(Admission admission)
        {
            _service.AddAdmission(admission);
        }

        public void UpdateAdmission(Admission admission)
        {
            _service.UpdateAdmission(admission);
        }

        public void DeleteAdmission(int admission)
        {
            _service.DeleteAdmission(admission);
        }
    }
}
