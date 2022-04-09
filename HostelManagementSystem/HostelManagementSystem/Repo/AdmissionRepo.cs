using HostelManagementSystem.Data;
using HostelManagementSystem.Infra;
using HostelManagementSystem.Model;
using HostelManagementSystem.ViewModel;
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

        public List<AdmissionVM> GetAdmissions()
        {
            //return _context.Admission.ToList();
            var result = (from a in _context.Admission

                          select new AdmissionVM
                          {
                              AdmissionId = a.AdmissionId,
                              FullName = a.FullName,
                              EmailId = a.EmailId,
                              MobileNo = a.MobileNo,
                              DateOfBirth = a.DateOfBirth,
                              BloodGroup = a.BloodGroup,
                              Caste = a.Caste,
                              GuardianName = a.GuardianName,
                              GuardianEmailId = a.GuardianEmailId,
                              GuardianMobileNo = a.GuardianMobileNo,
                              CourseName = a.CourseName,
                              CurrentYear = a.CurrentYear,
                              CollegeName = a.CollegeName,
                              HouseName = a.HouseName,
                              Locality = a.Locality,
                              City = a.City,
                              State = a.State,
                              Country = a.Country,
                              ZipCode = a.ZipCode,
                              createdAT = a.createdAT,
                              createdBy = a.createdBy,


                          }).ToList();
            return result;
        }

        public AdmissionVM GetAdmissionById(int AdmissionId)
        {
            //return _context.Admission.FirstOrDefault(a => a.AdmissionId == AdmissionId);
            var result = (from a in _context.Admission

                          select new AdmissionVM
                          {
                              AdmissionId = a.AdmissionId,
                              FullName = a.FullName,
                              EmailId = a.EmailId,
                              MobileNo = a.MobileNo,
                              DateOfBirth = a.DateOfBirth,
                              BloodGroup = a.BloodGroup,
                              Caste = a.Caste,
                              GuardianName = a.GuardianName,
                              GuardianEmailId = a.GuardianEmailId,
                              GuardianMobileNo = a.GuardianMobileNo,
                              CourseName = a.CourseName,
                              CurrentYear = a.CurrentYear,
                              CollegeName = a.CollegeName,
                              HouseName = a.HouseName,
                              Locality = a.Locality,
                              City = a.City,
                              State = a.State,
                              Country = a.Country,
                              ZipCode = a.ZipCode,
                              createdAT = a.createdAT,
                              createdBy = a.createdBy,

                          }).FirstOrDefault();
            return result;
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
