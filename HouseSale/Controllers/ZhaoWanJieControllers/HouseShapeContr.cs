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
    public class HouseShapeContr : ControllerBase
    {
        HouseShapeBll shapeBll = new HouseShapeBll();

        /// <summary>
        /// 显示房间信息
        /// </summary>
        /// <param name="name">根据经纪人</param>
        /// <param name="tation">朝向</param>
        /// <param name="hid">户型</param>
        /// <param name="htid">楼盘</param>
        /// <returns></returns>
        [HttpGet]
        public ShapePage GetHouseShapes(int aid, string tation, int hid, int htid, int pageindex, int pagesize)
        {
            return shapeBll.GetHouseShapes(aid, tation, hid, htid, pageindex, pagesize);
        }

        /// <summary>
        /// 添加房间信息
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddHouseShape(HouseShape s)
        {
            return shapeBll.AddHouseShape(s);
        }

        /// <summary>
        /// 修改房间信息
        /// </summary>
        /// <param name="price">修改单价</param>
        /// <param name="state">修改放假状态</param>
        /// <param name="aid">修改经纪人</param>
        /// <param name="hid">修改户型</param>
        /// <param name="htid">修改楼盘</param>
        /// <param name="hsid"></param>
        /// <returns></returns>
        [HttpPost]
        public int UpdateHouseShape(string price, int state, int aid, int hid, int htid, int hsid)
        {
            return shapeBll.UpdateHouseShape(price, state, aid, hid, htid, hsid);
        }
    }
}
