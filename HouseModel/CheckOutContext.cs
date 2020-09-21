using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseModel
{
    [Table("CheckOutContext")]
    public class CheckOutContext
    {
        [Key]
        /// <summary>
        /// 主键Id
        /// </summary>
        public int CId { get; set; }
        /// <summary>
        /// 客户外键
        /// </summary>
        public int ClientId { get; set; }
        /// <summary>
        /// 房型外键
        /// </summary>
        public int HouseId { get; set; }
        /// <summary>
        /// 退房日期
        /// </summary>
        public DateTime OutDatetime { get; set; }
        /// <summary>
        /// 退房状态
        /// </summary>
        public int OutHouseState { get; set; }
        /// <summary>
        /// 退房原因
        /// </summary>
        public string OutHouseCause { get; set; }
        /// <summary>
        /// 经纪人外键
        /// </summary>
        public int BrokerId { get; set; }
    }
}
