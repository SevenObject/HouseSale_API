
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Text;

namespace HouseModel
{
    [Table("HouseInfos")]
    public class HouseInfos
    {
        ///// <summary>
        ///// 房产信息主键
        ///// </summary>
        //public int HTSId { get; set; }
        ///// <summary>
        ///// 房产名称
        ///// </summary>
        //public string HTSName { get; set; }
        ///// <summary>
        ///// 图片
        ///// </summary>
        //public string HTPictures { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public string HTSPrice { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public int HTId { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public int AddressId { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public int HId { get; set; }
        ///// <summary>
        ///// 
        ///// </summary>
        //public int TId { get; set; }

        [Key]
        //主键
        public int HTSId { get; set; }
        /// <summary>
        /// 楼盘名称
        /// </summary>
        public string HTSName { get; set; }
        public string HNames { get; set; }
        /// <summary>
        /// 楼盘图片
        /// </summary>
        public string HTPictures { get; set; }
        /// <summary>
        /// 楼盘外键
        /// </summary>
        public int HTId { get; set; }
        /// <summary>
        /// 地址外键
        /// </summary>
        public int AddressId { get; set; }
        /// <summary>
        /// 户型外键
        /// </summary>
        public int HId { get; set; }
        /// <summary>
        /// 楼房类型
        /// </summary>
        public int TId { get; set; }
        /// <summary>
        /// 房子类型
        /// </summary>
        public string TName { get; set; }
        public string TFloor { get; set; }
        public int ImgId { get; set; }
        /// <summary>
        /// 图片集
        /// </summary>
        public string Imges { get; set; }
        /// <summary>
        /// 楼盘名称
        /// </summary>
        /// 
        public string HName { get; set; }
        /// <summary>
        /// 楼盘图片
        /// </summary>
        public string HTPicture { get; set; }
        /// <summary>
        /// 开盘日期
        /// </summary>
        public DateTime HTPDateTime { get; set; }
        /// <summary>
        /// 项目地址
        /// </summary>
        public string ProjictSite { get; set; }
        /// <summary>
        /// 售楼处
        /// </summary>
        public string SellHouse { get; set; }
        /// <summary>
        /// 开发商
        /// </summary>
        public string developers { get; set; }
        /// <summary>
        /// 销售状态
        /// </summary>
        public string SellState { get; set; }
        /// <summary>
        /// 建筑面积
        /// </summary>
        public string Architecturearea { get; set; }
        /// <summary>
        /// 交房时间
        /// </summary>
        public DateTime HandHouseTime { get; set; }
        /// <summary>
        /// 产权年限
        /// </summary>
        public string YearAstrict { get; set; }
        /// <summary>
        /// 建筑类别
        /// </summary>
        public string HouseState { get; set; }
        /// <summary>
        /// 容积率
        /// </summary>
        public string Plot { get; set; }
        /// <summary>
        /// 绿化率
        /// </summary>
        public string Greeningrate { get; set; }
        /// <summary>
        /// 周边规划
        /// </summary>
        public string Rim { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string HouseArea { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string PriceCount { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string HoousePicture { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public string Orientation { get; set; }
        /// <summary>
        /// 
        /// </summary>
        public DateTime BeginTime { get; set; }
        /// <summary>
        /// 房价
        /// </summary>
        public string HTSPrice { get; set; }
    }

    public class Pagees
    {
        public int pageIndex { get; set; }//当前页
        public int pageSize { get; set; }//条数
        public int pageCount { get; set; }//总页数
        public int allCount { get; set; }//总条数
        public List<HouseInfos> houseInfos { get; set; }
    }

}