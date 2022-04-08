using HostelManagementSystem.Data;
using HostelManagementSystem.Infra;
using HostelManagementSystem.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HostelManagementSystem.Repo
{
    public class AdmissionRepo:IAdmission
    {
        HostelDbContext _context;
        public AdmissionRepo(HostelDbContext context)
        {
            _context = context;
        }

        public List<Admission> GetAdmissions()
        {
            return _context.Admission.ToList();
        }

        public Admission GetAdmissionById(int AdmissionId)
        {
            return _context.Admission.FirstOrDefault(a => a.AdmissionId == AdmissionId);
        }

        public void AddAdmission(Admission admission)
        {
            _context.Add(admission);
            _context.SaveChanges();
        }

        public void UpdateAdmission(Admission admission)
        {
            _context.Update(admission);
            _context.SaveChanges();
        }

        public void DeleteAdmission(int admission)
        {
            var deladmission = _context.Admission.Where(s => s.AdmissionId == admission).FirstOrDefault();
            if (deladmission != null)
            {
                _context.Remove(deladmission);
                _context.SaveChanges();
            }
        }
    }
}
