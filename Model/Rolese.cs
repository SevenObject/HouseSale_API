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
        /// 角色主键
        /// </summary>
        public int RId { get; set; }
        /// <summary>
        /// 角色名称
        /// </summary>
        public string RName { get; set; }
    }
}
