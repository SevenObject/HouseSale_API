
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace HouseModel
{
    [Table("HouseTypes")]
    public class HouseTypes
    {
        [Key]
        public int TId { get; set; }
        public string TName { get; set; }
        public string TFloor { get; set; }
    }
}