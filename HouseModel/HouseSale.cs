using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseModel
{
    [Table("HouseSale")]
    public class HouseSale
    {
        [Key]
        /// <summary>
        /// 房产销售主键
        /// </summary>
        public int HouseSaleId { get; set; }
        /// <summary>
        /// 经纪人外键
        /// </summary>
        public int AId { get; set; }
        /// <summary>
        /// 楼盘外键
        /// </summary>
        public int HPId { get; set; }
        /// <summary>
        /// 房型外键
        /// </summary>
        public int HouId { get; set; }
        /// <summary>
        /// 楼栋户型外键
        /// </summary>
        public int HouseXId { get; set; }
        /// <summary>
        /// 客户外键
        /// </summary>
        public int CId { get; set; }
        /// <summary>
        /// 房产销售日期
        /// </summary>
        public DateTime SaleDateTime { get; set; }
        /// <summary>
        /// 合同签订日期
        /// </summary>
        public DateTime WriteOkDatetime { get; set; }

    }
}
