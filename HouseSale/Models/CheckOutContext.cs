using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseSale.Models
{
    [Table("CheckOutContext")]
    public class CheckOutContext
    {
        [Key]
        /// <summary>
        /// 
        /// </summary>
        public int CId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ClientId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int HouseId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime OutDatetime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int OutHouseState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string OutHouseCause { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int BrokerId { get; set; }
    }
}
