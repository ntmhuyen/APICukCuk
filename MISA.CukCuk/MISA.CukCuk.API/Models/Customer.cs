using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.API.Models
{
    /// <summary>
    /// Thông tin khách hàng
    /// CreatedBy: NMHUYEN (03/03/2021)
    /// </summary>
    public class Customer
    {
        #region Declare
        public static List<Customer> ListCustomer = new List<Customer>() 
        {
        };
        #endregion

        #region Constructor
        public Customer()
        {
            CustomerId = Guid.NewGuid();
        }
        /// <summary>
        /// Khởi tạo khách hàng
        /// 
        /// </summary>
        /// <param name="customerCode">Mã khách hàng</param>
        /// <param name="fullName">Họ và tên</param>
        /// CreatedBy NMHUYEN(03/03/2021)
        public Customer(string customerCode, string fullName)
        {
            CustomerId = Guid.NewGuid();
            CustomerCode = customerCode;
            FullName = fullName;
        }
        #endregion

        #region Properties
        public Guid CustomerId { get; set; }
        /// <summary>
        /// Mã khách hàng
        /// </summary>
        public string CustomerCode { get; set; }

        /// <summary>
        /// Họ và tên khách hàng
        /// </summary>
        public string FullName { get; set; }

        /// <summary>
        /// Giới tính (0-Nữ; 1-Nam)
        /// </summary>
        public int Gender { get; set; }

        /// <summary>
        /// Mã thẻ thành viên
        /// </summary>
        public string MembercardCode { get; set; }

        /// <summary>
        /// ID nhóm khách hàng
        /// </summary>
        public Guid? CustomerGroupId { get; set; }

        /// <summary>
        /// Số điện thoại
        /// </summary>
        public string PhoneNumber { get; set; }


        /// <summary>
        /// Ngày sinh
        /// </summary>
        public DateTime? DateOfBirth { get; set; }

        /// <summary>
        /// Tên công ty
        /// </summary>
        public string CompanyName { get; set; }

        /// <summary>
        /// Mã số thuế
        /// </summary>
        public string CompanyTaxCode { get; set; }

        /// <summary>
        /// Email
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Địa chỉ
        /// </summary>
        public string Address { get; set; }

        /// <summary>
        /// Ghi chú
        /// </summary>
        public string Note { get; set; }

        /// <summary>
        /// Người tạo bản ghi
        /// </summary>
        public string CreatedBy  { get; set; }

        /// <summary>
        /// Ngày tạo bản ghi
        /// </summary>
        public DateTime? CreatedDate { get; set; }

        /// <summary>
        /// Người chỉnh sửa cuối
        /// </summary>
        public string Modifiedby { get; set; }

        /// <summary>
        /// Ngày chỉnh sửa gần nhất 
        /// </summary>
        public DateTime? ModifiedDate { get; set; }

        #endregion

        #region Method

        /// <summary>
        /// Lấy danh sách khách hàng
        /// </summary>
        /// <returns>List khách hàng</returns>
        /// CreateBy: NMHUYEN (03/03/2021)
        //public static List<Customer> GetCustomers()
        //{
        //    var customers = new List<Customer>();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        var customer = new Customer($"KH000{i+1}","Nguyễn Huyền");
        //        customers.Add(customer);
        //    }
        //    ListCustomer = customers;
        //    return customers;
        //}

        #endregion

        #region Other


        #endregion
    }
}
