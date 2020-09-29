using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HouseBLL.WangbaoyiBLL;
using HouseModel;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HouseSale.Controllers.WangbaoyiControllers
{
    [Route("api/[controller]")]
    [EnableCors("cors")]
    [ApiController]
    public class WangbaoyiController : ControllerBase
    {
        MyBLL bll = new MyBLL();
        #region 显示
        /// <summary>
        /// 显示合同列表
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        [HttpGet("ShowConList")]
        public List<ContractData> ShowConList(ContractData contract)
        {
            return bll.ShowConList(contract);
        }
        /// <summary>
        /// 显示合同信息
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        [HttpGet("ShowCon")]
        public List<ContractData> ShowCon(ContractData contract)
        {
            return bll.ShowCon(contract);
        }
        /// <summary>
        /// 预购买房产的编号
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
        [HttpGet("ShowHouseShape")]
        public List<HouseShape> ShowHouseShape(HouseShape shape)
        {
            return bll.ShowHouseShape(shape);
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        [HttpGet("Login")]
        public int Login(string name, string pwd)
        {
            return bll.Login(name, pwd);
        }
        /// <summary>
        /// 角色下拉
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        [HttpGet("ShowRole")]
        public List<Rolese> ShowRole(Rolese rolese)
        {
            return bll.ShowRole(rolese);
        }
        #endregion
        #region 添加
        /// <summary>
        /// 添加合同信息表
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        [HttpPost("AddCon")]
        public int AddCon(ContractData contract)
        {
            return bll.AddCon(contract);
        }
        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="rolese"></param>
        /// <returns></returns>
        [HttpPost("AddRole")]
        public int AddRole(Rolese rolese)
        {
            return bll.AddRole(rolese);
        }
        #endregion
        #region 修改
        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="rolese"></param>
        /// <returns></returns>
        [HttpPost("ModifyRole")]
        public int ModifyRole(Rolese rolese)
        {
            return bll.ModifyRole(rolese);
        }
        [HttpPost("ModifyHouseState")]
        public int ModifyHouseState(int Id)
        {
            return bll.ModifyHouseState(Id);
        }
        #endregion
        #region 删除
        /// <summary>
        /// 删除合同
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        [HttpPost("DeleteCon")]
        public int DeleteCon(ContractData contract)
        {
            return bll.DeleteCon(contract);
        }
        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        [HttpPost("DeleteRole")]
        public int DeleteRole(Rolese rolese)
        {
            return bll.DeleteRole(rolese);
        }
        /// <summary>
        /// 批删
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost("DelAll")]
        public int DelAll(string id = "0")
        {
            return bll.DelAll(id);
        }
        #endregion
    }
}
