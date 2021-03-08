using Dapper;
using MISA.Infrastructure.Models;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace MISA.Infrastructure
{
    public class CustomerContext
    {
        #region Method
        // Lấy toàn bộ danh sách khách hàng
        public IEnumerable<Customer> GetCustomers()
        {
            // Kết nối tới CSDL
                var connectionString = "Host = 47.241.69.179; " +
                    "Port =3306; " +
                    "Database = MF752_NMHUYEN_CukCuk; " +
                    "User Id = dev; " +
                    "Password = 12345678";
                IDbConnection dbConnection = new MySqlConnection(connectionString);
            //Khởi tạo các CommanText
                var customers = dbConnection.Query<Customer>("Proc_GetCustomers", commandType: CommandType.StoredProcedure);
            //Trả về dữ liệu
                return customers;
        }

        // Lấy thông tin khách hàng theo mã khách hàng

        //Thêm mới khách hàng

        //Sửa thông tin khách hàng

        //Xóa khách hàng theo khóa chính

        #endregion
    }
}
