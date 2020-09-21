using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseSale.Models
{
    [Table("Menu")]
    public class Menu
    {
        [Key]
        /// <summary>
        /// 
        /// </summary>
        public int MId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string MName { get; set; }
    }
}
