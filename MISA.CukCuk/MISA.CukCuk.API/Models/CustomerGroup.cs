using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MISA.CukCuk.API.Models
{
    /// <summary>
    /// Thông tin nhóm khách hàng
    /// CreatedBy: NMHUYEN (06/03/2021)
    /// </summary>
    public class CustomerGroup
    {
        #region Declare

        #endregion

        #region Constructor
        public CustomerGroup()
        {
            CustomerGroupId = Guid.NewGuid();
        }

        public CustomerGroup(string customerGroupName, string description)
        {
            CustomerGroupId = Guid.NewGuid();
            CustomerGroupName = customerGroupName;
            Description = description;

        }
        #endregion

        #region Properties
        /// <summary>
        /// Id nhóm khách hàng
        /// </summary>
        public Guid CustomerGroupId { get; set; }
        
        /// <summary>
        /// Tên nhóm khách hàng
        /// </summary>
        public string CustomerGroupName { get; set; }

        /// <summary>
        /// Id nhóm cha
        /// </summary>
        public Guid? ParentId { get; set; }

        /// <summary>
        /// Diễn giải
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// Người tạo bản ghi
        /// </summary>
        public string CreatedBy { get; set; }

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

       
        #endregion

        #region Other


        #endregion
    }
}
