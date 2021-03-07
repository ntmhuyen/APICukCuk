using MISA.CukCuk.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MySqlConnector;
using Dapper;
using System.Data;

namespace MISA.CukCuk.API.Service
{
    public class CustomerService
    {
        public IEnumerable<Customer> GetCustomers()
        {
            string connectionString = "Host = 47.241.69.179; " +
                "Port =3306; " +
                "Database = MF752_NMHUYEN_CukCuk; " +
                "User Id = dev; " +
                "Password = 12345678";
            IDbConnection dbConnection = new MySqlConnection(connectionString);
            //var customers = dbConnection.Query<Customer>("SELECT * FROM Customer", commandType: CommandType.Text);
            var customers = dbConnection.Query<Customer>("Proc_GetCustomers", commandType: CommandType.StoredProcedure);
            return customers;
        }


        public Customer GetCustomerById(Guid customerId)
        {
            string connectionString = "Host = 47.241.69.179; " +
                "Port =3306; " +
                "Database = MF752_NMHUYEN_CukCuk; " +
                "User Id = dev; " +
                "Password = 12345678";
            IDbConnection dbConnection = new MySqlConnection(connectionString);
            var customer = dbConnection.Query<Customer>($"SELECT * FROM Customer WHERE CustomerId = '{customerId.ToString()}'").FirstOrDefault();
            return customer;
        }


        public void InsertCustomer(Customer customer)
        {
            
        }

        public void UpdateCustomer(Customer customer)
        {
            var customerExist = Customer.ListCustomer.Where(c => c.CustomerId == customer.CustomerId).FirstOrDefault();
            if (customerExist != null)
            {
                Customer.ListCustomer.Remove(customerExist);
                Customer.ListCustomer.Add(customer);
            }
        }

        public void DeleteCustomer(Guid customerId)
        {
            var customerExist = Customer.ListCustomer.Where(c => c.CustomerId == customerId).FirstOrDefault();
            if (customerExist != null)
            {
                Customer.ListCustomer.Remove(customerExist);
            }
        }
    }
}
