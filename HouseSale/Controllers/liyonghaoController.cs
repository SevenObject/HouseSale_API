using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HouseBLL;
using HouseModel;
using HouseBLL.liyonghao;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

namespace HouseSale.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class liyonghaoController : ControllerBase
    {
        l_marketBLL bll = new l_marketBLL();
        [HttpGet]
        [Route("Show_market")]
        //房产销售显示
        public List<HouseSal> Show_market()
        {
            return bll.Show_market();
        }
        [HttpGet("Show_market2")]
        //房产未售显示
        public List<HouseSal> Show_market2()
        {
            return bll.Show_market2();
        }
        [HttpGet("Show_market3")]
        //退房登记显示
        public List<HouseSal> Show_market3()
        {
            return bll.Show_market3();
        }
        [HttpGet("Show_market4")]
        public List<HouseSal> Show_market4()
        {
            return bll.Show_market4();
        }
        [HttpGet("Show_check")]
        public List<CheckOutContext> Show_check()
        {
            return bll.Show_check();
        }
        [HttpPut("upt")]
        //修改
        public int upt(int id)
        {
            return bll.upt(id);
        }

    }
}
