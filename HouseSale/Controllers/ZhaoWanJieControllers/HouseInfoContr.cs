        using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HouseBLL.ZhaoWanJieBLL;
using HouseModel;

namespace HouseSale.Controllers.ZhaoWanJieControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HouseInfoContr : ControllerBase
    {
        HouseInfoBll infoBll = new HouseInfoBll();

        /// <summary>
        /// 显示楼盘信息
        /// </summary>
        /// <param name="hname">根据楼盘名称</param>
        /// <param name="htptime">根据开盘时间到</param>
        /// <param name="hantime">交房时间</param>
        /// <param name="pageindex">第几页</param>
        /// <param name="pagesize">每页几条</param>
        /// <returns></returns>
        [HttpGet]
        public Page GetHouseInfos(string hname, string htptime, string hantime, int pageindex, int pagesize)
        {
            return infoBll.GetHouseInfos(hname, htptime, hantime, pageindex, pagesize);
        }
        /// <summary>
        /// 修改楼盘信息
        /// </summary>
        /// <param name="sellstate">销售状态</param>
        /// <param name="handtime">交房时间</param>
        /// <param name="handtime">周边规划</param>
        /// <returns></returns>
        [HttpPost]
        public int UpdateHouseInfo(string sellstate, string handtime, string rim, int ids)
        {
            return infoBll.UpdateHouseInfo(sellstate, handtime, rim, ids);
        }
        /// <summary>
        /// 添加楼盘信息
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddHouseInfo(HouseInfo h)
        {
            return infoBll.AddHouseInfo(h);
        }
    }
}
