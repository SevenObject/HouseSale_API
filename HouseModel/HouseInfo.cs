using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseModel
{
    public class Page
    {
        public int pageIndex { get; set; }//页码
        public int pageSize { get; set; }//条数
        public int pageCount { get; set; }//总页数
        public int allCount { get; set; }//总条数
        public List<HouseInfo>  houseInfos { get; set; }
    }
    /// <summary>
    /// 楼盘管理表
    /// </summary>
    public class HouseInfo
    {
         
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
        public string HouseStates { get; set; }
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
        public int AddressId { get; set; }
    }
}
