using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Model
{
    [Table("UserRoleMenu")]
    public class UserRoleMenu
    {
        [Key]
        /// <summary>
        /// 用户角色菜单主键
        /// </summary>
        public int URMId { get; set; }
        /// <summary>
        /// 用户角色主键
        /// </summary>
        public int URId { get; set; }
        /// <summary>
        /// 权限菜单主键
        /// </summary>
        public int MId { get; set; }
    }
}
