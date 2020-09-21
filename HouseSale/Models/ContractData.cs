using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseSale.Models
{
    [Table("ContractData")]
    public class ContractData
    {
        [Key]
        /// <summary>
        /// 
        /// </summary>
        public int CId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int AId { get; set; }
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
        public string PriceUp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Pricedown { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string FirstBuyUp { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal WorkDate { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int PlaneNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string SealPicture { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal FirstBuyDown { get; set; }
    }
}
