using HouseBLL;
using HouseModel;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace HouseSale.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("cors")]

    public class HouseInfoesController : ControllerBase
    {
        HouseInfoBLL bll = new HouseInfoBLL();
        //public async Task<ActionResult<IEnumerable<HouseInfoes>>> GetHouse()
        //{
        //    return await 
        //}
        //[HttpGet]
        //[Route("GetHouse")]

        //public List<HouseInfos> GetHouse()
        //{

        //        return bll.GetHouse();    
        //}
        [HttpGet]
        [Route("GetHouse")]

        public Pagees GetHouse(string name, int pageindex = 1, int pagesize = 7)
        {
            var list = bll.GetHouse(name);
            if (pageindex < 1)
            {
                pageindex = 1;
            }
            var count = list.Count;
            int pagecount = 0;

            if (count % pagesize == 0)
            {
                pagecount = count / pagesize;
            }
            if (count % pagesize != 0)
            {
                pagecount = count / pagesize + 1;
            }
            if (pageindex > pagecount)
            {
                pageindex = pagecount;
            }
            var p = new Pagees();
            //p.houseInfos = list;
            p.pageCount = pagecount;
            p.pageIndex = pageindex;
            p.pageSize = pagesize;
            p.allCount = count;
            p.houseInfos = list.Skip<HouseInfos>((pageindex - 1) * pagesize).Take<HouseInfos>(pagesize).ToList();
            return p;
        }
        [HttpGet]
        [Route("Particulars")]
        //房子详情页
        public HouseInfos Particulars(int id)
        {
            return bll.Particulars(id);
        }
        [HttpGet]
        [Route("HouseImg")]
        public List<HouseInfos> HouseImg(int id)
        {
            return bll.HouseImg(id);
        }

    }
}

