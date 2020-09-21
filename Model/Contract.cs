using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseSale.Models
{
    [Table("Contract")]
    public class Contract
    {
        [Key]
        /// <summary>
        /// 合同表主键
        /// </summary>
        public int CId { get; set; }
        /// <summary>
        /// 经纪人外键
        /// </summary>
        public int JId { get; set; }
        /// <summary>
        /// 客户外键
        /// </summary>
        public int ClientId { get; set; }
        /// <summary>
        /// 合同单号
        /// </summary>
        public int HTId { get; set; }
    }
}
