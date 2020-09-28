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
    [EnableCors("cors")]
    [ApiController]
    public class HousTypeContr : ControllerBase
    {
        HousTypeBll typeBll = new HousTypeBll();

        /// <summary>
        /// 显示户型信息
        /// </summary>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <param name="htid">根据楼盘查询</param>
        /// <param name="orien">根据朝向</param>
        /// <param name="price">根据价格区间</param>
        /// <param name="prices">根据价格区间</param>
        /// <returns></returns>
        [HttpGet]
        public Fen GetHousTypes(int pageindex, int pagesize, int htid, string orien, string price, string prices)
        {
            return typeBll.GetHousTypes(pageindex, pagesize, htid, orien, price, prices);
        }

        /// <summary>
        /// 添加户型信息
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddHousType(HousType h)
        {
            return typeBll.AddHousType(h);
        }

        /// <summary>
        /// 修改户型价格
        /// </summary>
        /// <param name="price"></param>
        /// <param name="hid"></param>
        /// <returns></returns>
        [HttpPost]
        public int UpdateHousType(string price, int hid)
        {
            return typeBll.UpdateHousType(price, hid);
        }
        [HttpGet]
        public Fen Sel(int ids, int pageindex, int pagesize)
        {
            return typeBll.Sel(ids, pageindex, pagesize);
        }
        [HttpGet]
        public List<HousType> SeleHousType()
        {
            return typeBll.SeleHousType();
        }
        public List<HousType> SeleHous(int ids)
        {
            return typeBll.SeleHous(ids);
        }
    }
}
