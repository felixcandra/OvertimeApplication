using Overtime.DataAccess.Model;
using Overtime.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.Common.Interface.Master
{
    public interface iEmployeeRepository
    {
        bool Insert(EmployeeParam employeeParam);
        bool Update(int? id, EmployeeParam employeeParam);
        bool Delete(int? id);
        List<Employee> Get();
        Employee Get(int? id);
        List<Employee> Search(string search, string cmb);
    }
}
