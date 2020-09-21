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
        /// 
        /// </summary>
        public int HTId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int HouseId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int SaleId { get; set; }
    }
}
