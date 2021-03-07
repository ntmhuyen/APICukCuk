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
    public class CustomerGroupsController : ControllerBase
    {
        /// <summary>
        /// Lấy danh sách nhóm khách hàng
        /// </summary>
        /// <returns>danh sách nhom khách hàng</returns>
        /// CreatedBy: NMHUYEN (06/03/2021)
        [HttpGet]
        public IActionResult GetCustomerGroups()
        {
            var customerGroupService = new CustomerGroupService();
            var customerGroups = customerGroupService.GetCustomerGroups().ToList();
            if (customerGroups.Count > 0)
            {
                return StatusCode(200, customerGroups);
            }
            else
            {
                return StatusCode(204, customerGroups);
            }
        }

        /// <summary>
        /// Lấy 1 nhóm khách hàng theo Id
        /// </summary>
        /// <param name="customerGroupId">Id của nhóm khách hàng</param>
        /// <returns>1 nhóm khách hàng</returns>
        /// CreatedBy: NMHUYEN (06/03/2021)
        [HttpGet("{customerGroupId}")]
        public IActionResult GetCustomerGroupbyId(Guid customerGroupId)
        {
            var customerGroupService = new CustomerGroupService();
            var customerGroup = customerGroupService.GetCustomerGroupById(customerGroupId);
            if (customerGroup != null)
            {
                return StatusCode(200, customerGroup);
            }
            else
            {
                return StatusCode(204, customerGroup);
            }
        }

        [HttpPost]
        public IActionResult Post(CustomerGroup customerGroup)
        {
            try
            {
                var customerGroupService = new CustomerGroupService();
                if (customerGroup.CustomerGroupName == "")
                {
                    return StatusCode(400, new
                    {
                        devMsg = "CustomerGroupName is required!",
                        userMsg = "Thông tin tên nhóm khách hàng không được để trống!",
                        errorCode = "001",
                        moreInfo = "",
                        traceId = ""
                    });
                }
                else
                {
                    customerGroupService.InsertCustomerGroup(customerGroup);
                    return StatusCode(201, "Thêm thành công!");
                }
            }
            catch (Exception)
            {

                return StatusCode(500, new
                {
                    devMsg = "Exception",
                    userMsg = "Thông tin tên nhóm khách hàng không được để trống!",
                    errorCode = "002",
                    moreInfo = "",
                    traceId = ""
                });
            }

        }
    }
}
