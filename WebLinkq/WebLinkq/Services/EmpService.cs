using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebLinkq.Models;

namespace WebLinkq.Services
{
    public class EmpService
    {
        private readonly IEmpRepository _repo = null;
        public EmpService(IEmpRepository repo)
        {
            _repo = repo;
        }
       
        public List<Emp> GetEmps()
        {
            return _repo.GetAllEmp();
        }
        public Emp GetEmpById(int EmpId)
        {
            return _repo.GetEmpById(EmpId);
        }

    }
}
