﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Overtime.DataAccess.Model;
using Overtime.DataAccess.Param;

namespace Overtime.Common.Interface.Master
{
    public class EmployeeRepository : iEmployeeRepository
    {
        Employee employee = new Employee();
        MyContex _context = new MyContex();
        bool status = false;
        public bool Delete(int? id)
        {
            var result = 0;
            Employee employee = Get(id);
            employee.isDelete = true;
            employee.deleteDate = DateTimeOffset.Now.LocalDateTime;
            result = _context.SaveChanges();
            if (result > 0)
            {
                status = true;
            }
            return status;
        }

        public List<Employee> Get()
        {
            var getAll = _context.Employees.Where(x => x.isDelete == false).ToList();
            return getAll;
        }

        public Employee Get(int? id)
        {
            var get = _context.Employees.Find(id);
            return get;
        }

        public bool Insert(EmployeeParam employeeParam)
        {
            var result = 0;
            employee.first_name = employeeParam.first_name;
            employee.last_name = employeeParam.last_name;
            employee.username = employeeParam.username;
            employee.password = employeeParam.password;
            employee.address = employeeParam.address;
            employee.sub_district = employeeParam.sub_district;
            employee.district = employeeParam.district;
            employee.province = employeeParam.province;
            employee.postal_code = employeeParam.postal_code;
            employee.salary = employeeParam.salary;
            employee.phone = employeeParam.phone;
            employee.position_id = employeeParam.position_id;
            employee.createDate = DateTimeOffset.Now.LocalDateTime;
            result = _context.SaveChanges();
            if(result > 0)
            {
                status = true;
            }
            return status;
        }

        public List<Employee> Search(string search, string cmb)
        {
            if(cmb == "Id")
            {
                var searchId = _context.Employees.Where(x => x.isDelete == false && x.Id.ToString().Contains(search)).ToList();
                return searchId;
            }
            else if (cmb == "First Name")
            {
                var searchFirstName = _context.Employees.Where(x => x.isDelete == false && x.first_name.Contains(search)).ToList();
                return searchFirstName;
            }
            else if (cmb == "Last Name")
            {
                var searchLastName = _context.Employees.Where(x => x.isDelete == false && x.last_name.Contains(search)).ToList();
                return searchLastName;
            }
            else
            {
                var refresh = _context.Employees.Where(x => x.isDelete == false).ToList();
                return refresh;
            }
        }

        public bool Update(int? id, EmployeeParam employeeParam)
        {
            var result = 0;
            Employee employee = Get(id);
            employee.first_name = employeeParam.first_name;
            employee.last_name = employeeParam.last_name;
            employee.username = employeeParam.username;
            employee.password = employeeParam.password;
            employee.address = employeeParam.address;
            employee.sub_district = employeeParam.sub_district;
            employee.district = employeeParam.district;
            employee.province = employeeParam.province;
            employee.postal_code = employeeParam.postal_code;
            employee.salary = employeeParam.salary;
            employee.phone = employeeParam.phone;
            employee.position_id = employeeParam.position_id;
            employee.updateDate = DateTimeOffset.Now.LocalDateTime;
            if (result > 0)
            {
                status = true;
            }
            return status;
        }
    }
}