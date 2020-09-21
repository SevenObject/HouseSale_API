using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseSale.Models
{
    [Table("Rolese")]
    public class Rolese
    {
        [Key]
        /// <summary>
        /// 
        /// </summary>
        public int RId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string RName { get; set; }
    }
}
