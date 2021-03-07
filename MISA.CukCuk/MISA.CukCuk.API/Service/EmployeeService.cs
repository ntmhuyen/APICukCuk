using MISA.CukCuk.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.API.Service
{
    public class EmployeeService
    {
        /// <summary>
        /// Lấy danh sách nhân viên
        /// </summary>
        /// <returns>List nhân viên</returns>
        /// CreateBy: NMHUYEN (03/03/2021)

        public List<Employee> GetEmployees()
        {
            var employees = Employee.ListEmployee;
            var employees2 = Employee.ListEmployee;

            if (employees.Count == 0)
            {
                for (int i = 0; i < 10; i++)
                {
                    var employee = new Employee($"NV000{i + 1}", "Nguyễn Huyền", 0);
                    employees.Add(employee);
                }
            }  
            return employees;
        }

        /// <summary>
        /// Thêm nhân viên
        /// </summary>
        /// <param name="employee">Nhân viên mới</param>
        public void InsertEmployee(Employee employee)
        {
            Employee.ListEmployee.Add(employee);
        }

        /// <summary>
        /// Sửa thông tin nhân viên
        /// </summary>
        /// <param name="employee">Nhân viên sửa</param>
        public void UpdateEmployee(Employee employee)
        {
            var employeeExist = Employee.ListEmployee.Where(e => e.EmployeeId == employee.EmployeeId).FirstOrDefault();
            if(employeeExist != null)
            {
                Employee.ListEmployee.Remove(employeeExist);
                Employee.ListEmployee.Add(employee);
            }

        }

        /// <summary>
        /// Xóa nhân viên
        /// </summary>
        /// <param name="employeeId">Id nhân viên </param>
        public void DeleteEmployee(Guid employeeId)
        {
            var employeeExist = Employee.ListEmployee.Where(e => e.EmployeeId == employeeId).FirstOrDefault();
            if (employeeExist != null)
            {
                Employee.ListEmployee.Remove(employeeExist);
            }
        }
    }
}
