using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseSale.Models
{
    [Table("ClientData")]
    public class ClientData
    {
        [Key]
        /// <summary>
        /// 客户资料主键
        /// </summary>
        public int CId { get; set; }
        /// <summary>
        /// 客户姓名
        /// </summary>
        public string CName { get; set; }
        /// <summary>
        /// 客户手机号
        /// </summary>
        public string CPlaneNumber { get; set; }
        /// <summary>
        /// 客户首套
        /// </summary>
        public string ClientFirstHouse { get; set; }
        /// <summary>
        /// 客户贷款
        /// </summary>
        public string Clientloans { get; set; }
        /// <summary>
        /// 购房需求
        /// </summary>
        public string BuyHouseRole { get; set; }
    }
}
