using LinqMethod.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LinqMethod.Model
{
    public class EmpRepo: IEmp
    {
        databaseContext _context;
        public EmpRepo(databaseContext context)
        {
            _context = context;
        }
        public List<Emp> GetEmps()
        {
            return _context.Emp.ToList();

        }
        public Emp GetEmp(int EmpId)
        {
            return _context.Emp.FirstOrDefault(e => e.EmpId == EmpId);

        }
        public void AddEmp(Emp emp)

        {
            _context.Add(emp);
            _context.SaveChanges();
        }
        public void UpdateEmp(Emp emp)
        {
            _context.Update(emp);
            _context.SaveChanges();

        }
        public void DeleteEmp(Emp emp)
        {
            _context.Remove(emp);
            _context.SaveChanges();

        }
        public List<Emp> GetEmpbyname()
        {
            return _context.Emp.ToList();
        }
        public List<Emp> GetEmpsal()
        {
            return _context.Emp.ToList();
        }
        public List<Emp> GetEmp()
        {
            return _context.Emp.ToList();
        }
      
    }
}
