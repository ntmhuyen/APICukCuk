using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MISA.CukCuk.API.Models;
using MISA.CukCuk.API.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.API.API
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class EmployeesController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetEmployees()
        {
            var employeeService = new EmployeeService();
            var employees = employeeService.GetEmployees();
            if (employees.Count >0)
            {
                return StatusCode(200, employees);
            }
            else
            {
                return StatusCode(204, employees);
            }
        }

        [HttpPost]

        public IActionResult Post(Employee employee)
        {
            var employeeService = new EmployeeService();
            if(employee.EmployeeCode == "")
            {
                return StatusCode(400, new
                {
                    devMsg = "EmployeeCode is required!",
                    userMsg = "Mã nhân viên không được để trống",
                    errorCode = "001",
                    moreInfo = "",
                    traceId = ""
                });
            }
            else
            {
                employeeService.InsertEmployee(employee);
                return StatusCode(201, "Thêm thành công!");
            }

        }

        [HttpPut]
        public IActionResult Put(Employee employee)
        {
            var employeeService = new EmployeeService();
            if (employee.EmployeeCode == "")
            {
                return StatusCode(400, new
                {
                    devMsg = "EmployeeCode is required!",
                    userMsg = "Mã nhân viên không được để trống",
                    errorCode = "001",
                    moreInfo = "",
                    traceId = ""
                });
            }
            else
            {
                employeeService.UpdateEmployee(employee);
                return StatusCode(200, "Sửa thành công!");
            }

        }

        [HttpDelete]
        public IActionResult Delete(Guid employeeId)
        {
            var employeeService = new EmployeeService();
            employeeService.DeleteEmployee(employeeId);
            return StatusCode(200, "Xóa thành công!");

        }

    }
}
