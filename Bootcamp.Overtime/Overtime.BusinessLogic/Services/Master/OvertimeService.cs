﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Overtime.DataAccess.Model;
using Overtime.Common.Interface;
using Overtime.Common.Interface.Master;
using Overtime.Common.Interfaces;
using Overtime.Common.Interfaces.Master;
using Overtime.DataAccess.Param;

namespace Overtime.BussinessLogic.Services.Master
{
    public class OvertimeService : IOvertimeService
    {
        IOvertimeRepository _overtimeRepository = new OvertimeRepository();
        public List<Overtimes> Get()
        {
            return _overtimeRepository.Get();
        }

        public List<Overtimes> Get(int? Id)
        {
            return _overtimeRepository.Get(Id);
        }

        public Overtimes GetId(int? Id)
        {
            return _overtimeRepository.GetId(Id);
        }

<<<<<<< HEAD
        public List<Overtimes> GetSearch(int? id,int? bulan, int? tahun)
        {
            return _overtimeRepository.GetSearch(id,bulan,tahun);
=======
        public List<Overtimes> GetSearch(string search, string cmb)
        {
            return _overtimeRepository.GetSearch(search, cmb);
>>>>>>> dcdd46e2747bf33dd66b40d7e96c57a83d215acb
        }

        public bool Insert(OvertimeParam overtimeParam)
        {
            return _overtimeRepository.Insert(overtimeParam);
        }

        public bool Update(int? Id, OvertimeParam overtimeParam)
        {
            return _overtimeRepository.Update(Id, overtimeParam);
        }
    }
}
