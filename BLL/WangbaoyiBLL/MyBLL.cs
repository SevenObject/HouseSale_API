using HouseDAL.WangBaoYi;
using HouseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBLL.WangbaoyiBLL
{
    public class MyBLL
    {
        ContractDAL cdal = new ContractDAL();
        AdminDAL adal = new AdminDAL();
        RoleAndMenuDAL rdal = new RoleAndMenuDAL();
        #region 显示
        /// <summary>
        /// 显示合同列表
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        public List<ContractData> ShowConList(ContractData contract)
        {
            return cdal.ShowConList(contract);
        }
        /// <summary>
        /// 显示合同信息
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        public List<ContractData> ShowCon(ContractData contract)
        {
            return cdal.ShowCon(contract);
        }
        /// <summary>
        /// 预购买房产的编号
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
        public List<HouseShape> ShowHouseShape(HouseShape shape)
        {
            return cdal.ShowHouseShape(shape);
        }
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        public AdministratorData Login(string name, string pwd)
        {
            return adal.Login(name,pwd);
        }
        /// <summary>
        /// 角色下拉
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        public List<Rolese> ShowRole(Rolese rolese)
        {
            return rdal.ShowRole(rolese);
        }
        #endregion
        #region 添加
        /// <summary>
        /// 添加合同信息表
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        public int AddCon(ContractData contract)
        {
            return cdal.AddCon(contract);
        }
        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="rolese"></param>
        /// <returns></returns>
        public int AddRole(Rolese rolese)
        {
            return rdal.AddRole(rolese);
        }
        #endregion
        #region 修改
        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="rolese"></param>
        /// <returns></returns>
        public int ModifyRole(Rolese rolese)
        {
            return rdal.ModifyRole(rolese);
        }
        public int ModifyHouseState(int Id)
        {
            return cdal.ModifyHouseState(Id);
        }
        #endregion
        #region 删除
        /// <summary>
        /// 删除合同
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        public int DeleteCon(ContractData contract)
        {
            return cdal.DeleteCon(contract);
        }
        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        public int DeleteRole(Rolese rolese)
        {
            return rdal.DeleteRole(rolese);
        }
        /// <summary>
        /// 批删
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelAll(string id = "0")
        {
            return cdal.DelAll(id);
        }
        #endregion
    }
}
