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
    public class AdministratorDataContr : ControllerBase
    {
        AdministratorDataBll dataBll = new AdministratorDataBll();

        /// <summary>
        /// 显示经纪人信息
        /// </summary>
        /// <param name="name">姓名查询</param>
        /// <param name="begintime">入职时间</param>
        /// <param name="statime">到离职时间</param>
        /// <param name="card">经纪人工号</param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <returns></returns>
        [HttpGet]
        public AdminPage GetAdministratorDatas(string name, string begintime, string statime, string card, int pageindex, int pagesize)
        {
            return dataBll.GetAdministratorDatas(name, begintime, statime, card, pageindex, pagesize);
        }
        /// <summary>
        /// 添加经纪人信息
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        [HttpPost]
        public int Addadmin(AdministratorData d)
        {
            return dataBll.Addadmin(d);
        }

        /// <summary>
        /// 修改经纪人信息
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <param name="apost">职位</param>
        /// <param name="aid"></param>
        /// <returns></returns>
        [HttpPost]
        public int UpdateAdmin(string phone, string apost, int aid)
        {
            return dataBll.UpdateAdmin(phone, apost, aid);
        }
        [HttpGet]
        public List<AdministratorData> SeleAdministr(int ids)
        {
            return dataBll.SeleAdministr(ids);
        }
        public List<AdministratorData> SAdministr()
        {
            return dataBll.SAdministr();
        }
    }
}
