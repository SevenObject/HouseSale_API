using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseSale.Models
{
    [Table("UserRoleMenu")]
    public class UserRoleMenu
    {
        [Key]
        /// <summary>
        /// 
        /// </summary>
        public int URMId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int URId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int MId { get; set; }
    }
}
