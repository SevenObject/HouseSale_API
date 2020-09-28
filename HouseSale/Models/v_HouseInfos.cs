using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HouseSale.Models
{
    public class v_HouseInfos
    {
        public int HTSId { get; set; }//主键
        public string HTSName { get; set; }//房产名称
        public string HTSPrice { get; set; }//单价
        public string HTPictures { get; set; }//图片
        public string ProjictSite { get; set; }//项目地址
        public string HNames { get; set; }//配置
        public string HouseArea { get; set; }//面积
        public string Orientation { get; set; }//方位
        public string TName { get; set; }//类别名称
        public string TFLoor { get; set; }//垂直位置
    }
}
