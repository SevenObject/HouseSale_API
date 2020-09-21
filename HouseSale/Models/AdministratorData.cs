using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseSale.Models
{
    [Table("AdministratorData")]
    public class AdministratorData
    {
        [Key]
        /// <summary>
        /// 
        /// </summary>
        public int AId { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string AName { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal APlaneNumber { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public decimal Card { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime BeginTime { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string APicture { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string APosition { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public int CompanyCard { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Company { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Password { get; set; }
    }
}
