using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseModel
{
    [Table("Menu")]
    public class Menu
    {
        [Key]
        /// <summary>
        /// 权限菜单主键
        /// </summary>
        public int MId { get; set; }
        /// <summary>
        /// 权限菜单名称
        /// </summary>
        public string MName { get; set; }
    }
}
