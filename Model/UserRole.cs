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
        /// 用户角色主键
        /// </summary>
        public int URId { get; set; }
        /// <summary>
        /// 用户外键
        /// </summary>
        public int UId { get; set; }
        /// <summary>
        /// 角色外键
        /// </summary>
        public int RId { get; set; }
    }
}
