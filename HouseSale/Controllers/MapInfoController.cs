using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseBLL;
using HouseModel;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HouseSale.Controllers
{
    [Route("api/[controller]")]
    [EnableCors("cors")]
    [ApiController]
    public class MapInfoController : ControllerBase
    {
        AskBLL bll = new AskBLL();
        [Route("GetHouselist")]
        public CityCount GetHouselist(string poSite, int pagenow = 1, int pagesize = 7)
        {
            List<v_HouseInfos> list = bll.GetHouse();
            if (!String.IsNullOrEmpty(poSite))
            {
                list = list.Where(s => s.ProjictSite.Contains(poSite)).ToList();
            }
            int countdata = list.Count();
            int countpage = countdata / pagesize;
            if (pagenow < 1)
            {
                pagenow = 1;
            }
            if (countdata % pagesize > 0)
            {
                countpage += 1;
            }
            if(pagenow>countpage)
            {
                pagenow = countpage;
            }
            list = list.Skip<v_HouseInfos>((pagenow - 1) * pagesize).Take<v_HouseInfos>(pagesize).ToList();
            CityCount c = new CityCount();
            c.infos = list;
            c.dataCount = countdata;
            c.nowPage = pagenow;
            c.pageCount = countpage;
            return c;
        }
    }
}
