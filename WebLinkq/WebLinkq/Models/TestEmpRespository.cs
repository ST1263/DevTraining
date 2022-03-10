using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebLinkq.Models
{
    public class TestEmpRespository: IEmpRepository
    {
        public List<Emp> DataSource()
        {
            return new List<Emp>()
           {
               new Emp() { EmpId = 1, EmpName = "Shreyas", Dept = "Trinee" },
            new Emp() { EmpId = 2, EmpName = "Rutuja", Dept = "Trinee" }, 
            new Emp() { EmpId = 3, EmpName = "Shrutii", Dept = "Trinee" },
            new Emp() { EmpId = 4, EmpName = "Aishwarya", Dept = "Trinee" }
        };
        }
        
        public Emp GetEmpById(int EmpId)
    {
            /*return DataSource().FirstOrDefault(e => e.EmpId == EmpId);*/
            return DataSource().First(e => e.EmpId == EmpId);
            /*return DataSource().SingleOrDefault(e => e.EmpId == EmpId);*/
            /*return DataSource().Single(e => e.EmpId == EmpId);*/

        }
       

        public List<Emp> GetAllEmp()
        {
            return DataSource();
        }
    }
}
