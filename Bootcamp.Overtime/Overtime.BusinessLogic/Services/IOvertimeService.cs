using Overtime.DataAccess.Model;
using Overtime.DataAccess.Param;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Overtime.BussinessLogic.Services
{
    public interface IOvertimeService
    {
        List<Overtimes> Get();

        List<Overtimes> Get(int? Id);
        Overtimes GetId(int? Id);
        bool Insert(OvertimeParam overtimeParam);
        bool Update(int? Id,OvertimeParam overtimeParam);
<<<<<<< HEAD
        List<Overtimes> GetSearch(int? id,int? bulan, int? tahun);
=======
        List<Overtimes> GetSearch(string search, string cmb);
>>>>>>> dcdd46e2747bf33dd66b40d7e96c57a83d215acb
    }
}
