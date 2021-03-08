using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.Infrastructure.Models
{
    /// <summary>
    /// Thông tin nhân viên
    /// CreatedBy: NMHUYEN (03/03/2021)
    /// </summary>
    public class Employee
    {
        #region Declare
        public static List<Employee> ListEmployee = new List<Employee>();
        #endregion

        #region Constructor
        public Employee()
        {
        }

        /// <summary>
        /// Khởi tạo nhân viên
        /// </summary>
        /// <param name="emplyeeCode">Mã nhân viên</param>
        /// <param name="fullName">Họ và tên</param>
        /// <param name="gender">Giới tính</param>
        /// CreatedBy: NMHUYEN (03/03/2021)
        public Employee(string emplyeeCode, string fullName, int gender)
        {
            EmployeeId = Guid.NewGuid();
            EmployeeCode = emplyeeCode;
            FullName = fullName;
            Gender = gender;
        }
        #endregion

        #region Properties

        /// <summary>
        /// Id nhân viên
        /// </summary>
        public Guid EmployeeId { get; set; }
       
        /// <summary>
        /// Mã nhân viên
        /// </summary>
        public string EmployeeCode { get; set; }
        
        /// <summary>
        /// Họ tên nhân viên
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Giới tính (0-Nữ; 1-Nam)
        /// </summary>
        public int Gender { get; set; }

        /// <summary>
        /// Lương
        /// </summary>
        public double Salary { get; set; }

        /// <summary>
        /// Tình trạng hôn nhân (0-Độc thân; 1-Đã kết hôn)
        /// </summary>
        public int MaritalStatus { get; set; }

        #endregion

        #region Method

        /// <summary>
        /// Lấy danh sách nhân viên
        /// </summary>
        /// <returns>List nhân viên</returns>
        /// CreateBy: NMHUYEN (03/03/2021)
        public static List<Employee> GetEmployees()
        {
            var employees = new List<Employee>();
            for (int i = 0; i < 10; i++)
            {
                var employee = new Employee($"NV000{i + 1}", "Nguyễn Huyền", 0);
                employees.Add(employee);
            }
            ListEmployee = employees;
            return employees;
        }
        #endregion

        #region Other
        #endregion
    }
}
