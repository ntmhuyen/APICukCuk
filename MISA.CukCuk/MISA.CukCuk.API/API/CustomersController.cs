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
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        /// <summary>
        /// Lấy danh sách khách hàng
        /// </summary>
        /// <returns>Danh sách khách hàng</returns>
        [HttpGet]
        public IActionResult GetCustomers()
        {
            var customerService = new CustomerService();
            var customers = customerService.GetCustomers().ToList();
            if (customers.Count > 0)
            {
                return StatusCode(200, customers);
            }
            else
            {
                return StatusCode(204, customers);
            }
        }

        /// <summary>
        /// Lấy 1 khách hàng theo Id
        /// </summary>
        /// <param name="customerId">Id của khách hàng</param>
        /// <returns>Khách hàng</returns>
        [HttpGet("{customerId}")]
        public IActionResult GetCustomerById(Guid customerId)
        {
            var customerService = new CustomerService();
            var customers = customerService.GetCustomerById(customerId);
            if (customers != null)
            {
                return StatusCode(200, customers);
            }
            else
            {
                return StatusCode(204, customers);
            }
        }

        [HttpPost]
        public IActionResult Post(Customer customer)
        {
            try
            {
                var customerService = new CustomerService();
                if (customer.CustomerCode == "")
                {
                    return StatusCode(400, new
                    {
                        devMsg = "CustomerCode required!",
                        userMsg = "Thông tin mã khách hàng không được để trống!",
                        errorCode = "001",
                        moreInfo = "",
                        traceId = ""
                    });
                }
                else
                {
                    customerService.InsertCustomer(customer);
                    return StatusCode(201, "Thêm thành công!");
                }
            }
            catch (Exception)
            {

                return StatusCode(500, new
                {
                    devMsg = "Exception",
                    userMsg = "Thông tin mã khách hàng không được để trống!",
                    errorCode = "002",
                    moreInfo = "",
                    traceId = ""
                });
            }

        }


        [HttpPut]
        public void Put(Customer customer)
        {
            var customerService = new CustomerService();
            customerService.UpdateCustomer(customer);
        }

        [HttpDelete("{customerId}")]
        public void Delete(Guid customerId)
        {
            var customerService = new CustomerService();
            customerService.DeleteCustomer(customerId);
        }
    }
}

