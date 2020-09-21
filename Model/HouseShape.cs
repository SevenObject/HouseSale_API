using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseSale.Models
{
    [Table("HouseShape")]
    public class HouseShape
    {
        [Key]
        /// <summary>
        /// 主键Id
        /// </summary>
        public int HSId { get; set; }
        /// <summary>
        /// 房间号
        /// </summary>
        public string HNumber { get; set; }
        /// <summary>
        /// 房间图片
        /// </summary>
        public string HousePicture { get; set; }
        /// <summary>
        /// 均价
        /// </summary>
        public string AveragePrice { get; set; }
        /// <summary>
        /// 房间状态
        /// </summary>
        public int HouseState { get; set; }
        /// <summary>
        /// 经纪人外键
        /// </summary>
        public int AId { get; set; }
        /// <summary>
        /// 户型外键
        /// </summary>
        public int HId { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime BeginTime { get; set; }
    }
}
