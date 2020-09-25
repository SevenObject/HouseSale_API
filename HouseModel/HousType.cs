using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseModel
{
    public class Fen
    {
        public int pageIndex { get; set; }//页码
        public int pageSize { get; set; }//条数
        public int pageCount { get; set; }//总页数
        public int allCount { get; set; }//总条数
        public List<HousType>  housTypes { get; set; }
    }
    /// <summary>
    /// 楼栋户型表
    /// </summary>
    public class HousType
    {

        /// <summary>
        /// 户型主键
        /// </summary>
        public int HId { get; set; }
        /// <summary>
        /// 户型名称
        /// </summary>
        public string HNames { get; set; }
        /// <summary>
        ///  建筑面积
        /// </summary>
        public string HouseArea { get; set; }
        /// <summary>
        /// 总价
        /// </summary>
        public string PriceCount { get; set; }
        /// <summary>
        /// 户型图片
        /// </summary>
        public string HoousePicture { get; set; }
        /// <summary>
        /// 朝向
        /// </summary>
        public string Orientation { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime BeginTime { get; set; }
        /// <summary>
        /// 楼栋外键
        /// </summary>
        public int HTId { get; set; }
        /// <summary>
        /// 楼盘名称
        /// </summary>
        public string HName { get; set; }
        /// <summary>
        /// 售楼处
        /// </summary>
        public string SellHouse { get; set; }
        /// <summary>
        /// 交房时间
        /// </summary>
        public DateTime HandHouseTime { get; set; }
    }
}
