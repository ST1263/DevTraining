using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqMethod.Model
{
    public interface IEmp
    {
        public List<Emp> GetEmps();
        public Emp GetEmp(int EmpId);
        public void AddEmp(Emp emp);
        public void UpdateEmp(Emp emp);
        public void DeleteEmp(Emp emp);
        public List<Emp> GetEmpbyname();
        public List<Emp> GetEmpsal();
    
    }
}