using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseSale.Models
{
    [Table("Contract")]
    public class Contract
    {
        [Key]
        /// <summary>
        /// 
        /// </summary>
        public int CId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int JId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int ClientId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int HTId { get; set; }
    }
}
