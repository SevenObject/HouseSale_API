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
    public class ClientDataBllContr : ControllerBase
    {
        ClientDataBll clenbll = new ClientDataBll();
        /// <summary>
        /// 经纪人只能查看自己所属的客户
        /// </summary>
        /// <param name="aid"></param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <param name="daikan"></param>
        /// <returns></returns>
        [HttpGet]
        public ClienPage GetClientDatas(int aid, int pageindex, int pagesize, int daikan)
        {
            return clenbll.GetClientDatas(aid, pageindex, pagesize, daikan);
        }
        /// <summary>
        /// 添加客户信息
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        [HttpPost]
        public int AddClient(ClientData c)
        {
            return clenbll.AddClient(c);
        }
    }
}
