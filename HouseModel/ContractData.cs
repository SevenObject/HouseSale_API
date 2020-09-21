using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseModel
{
    [Table("ContractData")]
    public class ContractData
    {
        [Key]
        /// <summary>
        /// 合同信息主键
        /// </summary>
        public int CId { get; set; }
        /// <summary>
        /// 管理员外键
        /// </summary>
        public int AId { get; set; }
        /// <summary>
        /// 客户外键
        /// </summary>
        public int ClientId { get; set; }
        /// <summary>
        /// 房产外键
        /// </summary>
        public int HouseId { get; set; }
        /// <summary>
        /// 总价(大写)
        /// </summary>
        public string PriceUp { get; set; }
        /// <summary>
        /// 总价(小写)
        /// </summary>
        public decimal Pricedown { get; set; }
        /// <summary>
        /// 首付(大写)
        /// </summary>
        public string FirstBuyUp { get; set; }
        /// <summary>
        /// 签约日期
        /// </summary>
        public decimal WorkDate { get; set; }
        /// <summary>
        /// 联系电话
        /// </summary>
        public int PlaneNumber { get; set; }
        /// <summary>
        /// 盖章图片
        /// </summary>
        public string SealPicture { get; set; }
        /// <summary>
        /// 首付(小写)
        /// </summary>
        public decimal FirstBuyDown { get; set; }
    }
}
