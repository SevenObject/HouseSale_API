using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseModel
{
    public class ShapePage
    {
        public int pageIndex { get; set; }//页码
        public int pageSize { get; set; }//条数
        public int pageCount { get; set; }//总页数
        public int allCount { get; set; }//总条数
        public List<HouseShape>  houseShapes { get; set; }
    }
    /// <summary>
    /// 房间表
    /// </summary>
    public class HouseShape
    {

        /// <summary>
        /// 房间主键Id
        /// </summary>..............
        public int HSId { get; set; }
        /// <summary>
        /// 房间号
        /// </summary>
        public string HNumber { get; set; }
        /// <summary>
        /// 房间图片
        /// </summary>
        public string HousePicture { get; set; }
        /// <summary>
        /// 均价
        /// </summary>
        public string AveragePrice { get; set; }
        /// <summary>
        /// 房间状态
        /// </summary>
        public int HouseState { get; set; }
        /// <summary>
        /// 经纪人外键
        /// </summary>
        public int AId { get; set; }
        /// <summary>
        /// 户型外键
        /// </summary>
        public int HId { get; set; }
        /// <summary>
        /// 添加时间
        /// </summary>
        public DateTime BeginTime { get; set; }

        /// <summary>
        /// 户型名称
        /// </summary>
        public string HNames { get; set; }
        /// <summary>
        /// 楼盘表主键
        /// </summary>
        public int HTId { get; set; }
        /// <summary>
        /// 楼盘名称
        /// </summary>
        /// 
        public string HName { get; set; }
        /// <summary>
        /// 售楼处
        /// </summary>
        public string SellHouse { get; set; }
        /// <summary>
        /// 交房时间
        /// </summary>
        public DateTime HandHouseTime { get; set; }
        /// <summary>
        /// 产权年限
        /// </summary>
        public string YearAstrict { get; set; }
         
        /// <summary>
        /// 管理员姓名
        /// </summary>
        public string AName { get; set; }
    }

}
