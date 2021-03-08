using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;
using Dapper;
using System.Data;
using MISA.CukCuk.API.Models;

namespace MISA.CukCuk.API.Service
{
    public class CustomerGroupService
    {
        public IEnumerable<CustomerGroup> GetCustomerGroups()
        {
            string connectionString = "Host = 47.241.69.179; " +
                "Port =3306; " +
                "Database = MF752_NMHUYEN_CukCuk; " +
                "User Id = dev; " +
                "Password = 12345678";
            IDbConnection dbConnection = new MySqlConnection(connectionString);
            //var customerGroups = dbConnection.Query<CustomerGroup>("SELECT * FROM CustomerGroup");
            //var customerGroups = dbConnection.Query<CustomerGroup>("SELECT * FROM CustomerGroup", commandType: CommandType.Text);
            var customerGroups = dbConnection.Query<CustomerGroup>("Proc_GetCustomerGroup", commandType: CommandType.StoredProcedure);
            return customerGroups;
        }

        public CustomerGroup GetCustomerGroupById(Guid customerGroupId)
        {
            string connectionString = "Host = 47.241.69.179; " +
                "Port =3306; " +
                "Database = MF752_NMHUYEN_CukCuk; " +
                "User Id = dev; " +
                "Password = 12345678";
            IDbConnection dbConnection = new MySqlConnection(connectionString);
            var customerGroup = dbConnection.Query<CustomerGroup>($"SELECT * FROM CustomerGroup WHERE CustomerGroupId = '{customerGroupId}'").FirstOrDefault();
            return customerGroup;
        }

        public int InsertCustomerGroup(CustomerGroup customerGroup)
        {
            //var properties = customerGroup.GetType().GetProperties();
            //var parameters = new DynamicParameters();
            //foreach (var property in properties)
            //{
            //    var propertyName = property.Name;
            //    var propertyValue = property.GetValue(customerGroup);
            //    var propertyType = property.PropertyType;
            //    if (propertyType == typeof(Guid) || propertyType == typeof(Guid?))
            //    {
            //        parameters.Add($"@{propertyName}", propertyValue, DbType.String);

            //    }
            //    else
            //    {
            //        parameters.Add($"@{propertyName}", propertyValue);
            //    }

            //}
            string connectionString = "Host = 47.241.69.179; " +
               "Port =3306; " +
               "Database = MF752_NMHUYEN_CukCuk; " +
               "User Id = dev; " +
               "Password = 12345678";
            IDbConnection dbConnection = new MySqlConnection(connectionString);
            var rowAffects = dbConnection.Execute("Proc_InsertCustomerGroup", customerGroup, commandType: CommandType.StoredProcedure);
            return rowAffects;
        }

        public int UpdateCustomerGroup(CustomerGroup customerGroup)
        {
            string connectionString = "Host = 47.241.69.179; " +
               "Port =3306; " +
               "Database = MF752_NMHUYEN_CukCuk; " +
               "User Id = dev; " +
               "Password = 12345678";
            IDbConnection dbConnection = new MySqlConnection(connectionString);
            var rowAffects = dbConnection.Execute("Proc_UpdateCustomerGroup",customerGroup, commandType: CommandType.StoredProcedure);
            return rowAffects;


            //var customerGroupExist = CustomerGroup.ListCustomerGroup.Where(c => c.CustomerGroupId == customerGroup.CustomerGroupId).FirstOrDefault();
            //if (customerGroupExist != null)
            //{
            //    CustomerGroup.ListCustomerGroup.Remove(customerGroupExist);
            //    CustomerGroup.ListCustomerGroup.Add(customerGroupExist);
            //}
        }

    }
}
