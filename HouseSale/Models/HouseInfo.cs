using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseSale.Models
{
    [Table("HouseInfo")]
    public class HouseInfo
    {
        [Key]
        /// <summary>
        /// 
        /// </summary>
        public int HTId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        /// 
        public string HName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string HTPicture { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal HTPDateTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string ProjictSite { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SellHouse { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string developers { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SellState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Architecturearea { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string HandHouseTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string YearAstrict { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string HouseState { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Plot { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Greeningrate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Rim { get; set; }
        public int AddressId { get; set; }
    }
}
