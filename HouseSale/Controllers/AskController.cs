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
    public class AskController : ControllerBase
    {
        AskBLL bll = new AskBLL();
        [HttpGet]
        [Route("GetAdministrators")]
        public List<AdministratorData> GetAdministrators(int aid)
        {
            return bll.GetAdmins(aid);
        }
    }
}
