using LinqMethod.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqMethod.Service
{
    public class EmpService
    {
        IEmp _service;
        public EmpService(IEmp service)
        {
            _service = service;
        }
        public List<Emp> GetEmps()
        {
            List<Emp> emp = _service.GetEmps();
            return emp.OrderBy(c => c.EmpName).ToList();

        }
        public Emp GetEmp(int EmpID)
        {
            return _service.GetEmp(EmpID);

        }
        public void AddEmp(Emp emp)
        {
            _service.AddEmp(emp);
        }
        public void UpdateEmp(Emp emp)
        {
            _service.UpdateEmp(emp);
        }
        public void DeleteEmp(Emp emp)
        {
            _service.DeleteEmp(emp);
        }
        public List<Emp> GetEmpbyname()
        {
            List<Emp> emp = _service.GetEmpbyname();
            return emp.Where(e => e.salary >= 8000).ToList();

        }
     
        
    }
}
