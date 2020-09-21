using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseSale.Models
{
    [Table("HouseSale")]
    public class HouseSale
    {
        [Key]
        /// <summary>
        /// 
        /// </summary>
        public int HouseSaleId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int AId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int HPId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int HouId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int HouseXId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int CId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime SaleDateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime WriteOkDatetime { get; set; }

    }
}
