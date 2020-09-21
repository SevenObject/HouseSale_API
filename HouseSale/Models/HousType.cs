using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseSale.Models
{
    [Table("HousType")]
    public class HousType
    {
        [Key]
        /// <summary>
        /// 
        /// </summary>
        public int HId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string HName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string HouseArea { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PriceCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string HoousePicture { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Orientation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime BeginTime { get; set; }
    }
}
