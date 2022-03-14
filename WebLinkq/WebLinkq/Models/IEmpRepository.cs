using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLinkq.Models
{
   public interface IEmpRepository
    {
        Emp GetEmpById(int EmpId);
        List<Emp> GetAllEmp();
    }
}
