using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseModel
{
    [Table("HouseSale")]
    public class HouseSal
    {
        [Key]
        /// <summary>
        /// 房产销售主键
        /// </summary>
        public int HouseSaleId { get; set; }
        /// <summary>
        /// 经纪人外键
        /// </summary>
        public string AName { get; set; }
        /// <summary>
        /// 楼盘外键
        /// </summary>
        public string HName { get; set; }
        /// <summary>
        /// 房型外键
        /// </summary>
        public string HNames { get; set; }
        /// <summary>
        /// 楼栋户型外键
        /// </summary>
        public string HNumber { get; set; }
        /// <summary>
        /// 客户外键
        /// </summary>
        public string CName { get; set; }
        /// <summary>
        /// 房产销售日期
        /// </summary>
        public DateTime SaleDateTime { get; set; }
        /// <summary>
        /// 合同签订日期
        /// </summary>
        public DateTime WriteOkDatetime { get; set; }
        public int HouseState { get; set; }

    }
    public class Pages
    {
        public List<HouseSal> HouseSal { get; set; }
        public int totalCount { get; set; } //总条数
        public int totalPage { get; set; } //总页数
        public int currentPage { get; set; } //当前页
    }
}
