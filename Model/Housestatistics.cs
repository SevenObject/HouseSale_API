using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseSale.Models
{
    [Table("Housestatistics")]
    public class Housestatistics
    {
        [Key]
        /// <summary>
        /// 房态统计主键
        /// </summary>
        public int HTId { get; set; }
        /// <summary>
        /// 房型外键
        /// </summary>
        public int HouseId { get; set; }
        /// <summary>
        /// 销售外键
        /// </summary>
        public int SaleId { get; set; }
    }
}
