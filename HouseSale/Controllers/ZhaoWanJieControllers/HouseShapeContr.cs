using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HouseBLL.ZhaoWanJieBLL;
using HouseModel;
using Microsoft.AspNetCore.Cors;

namespace HouseSale.Controllers.ZhaoWanJieControllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    [EnableCors("cors")]
    public class HouseShapeContr : ControllerBase
    {
        HouseShapeBll shapeBll = new HouseShapeBll();

        /// <summary>
        /// 显示房间信息
        /// </summary>
 
        /// <param name="tation">朝向</param>
        /// <param name="hid">户型</param>
        /// <param name="htid">楼盘</param>
        /// <returns></returns>
        [HttpGet]
        public ShapePage GetHouseShapes(string tation, int hid, int htid, int pageindex, int pagesize)
        {
            return shapeBll.GetHouseShapes(tation,hid,htid,pageindex, pagesize);
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
        /// <param name="state">修改房间状态</param>
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
        [HttpGet]
        public ShapePage SeleShape(int ids, int pageindex, int pagesize)
        {
            return shapeBll.SeleShape(ids, pageindex, pagesize);
        }
        [HttpPost]
        public int UpdateState(int ids)
        {
            return shapeBll.UpdateState(ids);
        }
        [HttpGet]
        public List<HouseShape> SeleHou(int ids)
        {
            return shapeBll.SeleHou(ids);
        }
    }
}
