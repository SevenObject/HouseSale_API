using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseSale.Models
{
    [Table("UserRole")]
    public class UserRole
    {
        [Key]
        /// <summary>
        /// 
        /// </summary>
        public int URId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int UId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int RId { get; set; }
    }
}
