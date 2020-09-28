using HouseDAL.ZhaoWanJieDAL;
using HouseModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace HouseBLL.ZhaoWanJieBLL
{
   public class AdministratorDataBll
    {
        AdministratorDataDal dataDal = new AdministratorDataDal();

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
        public AdminPage GetAdministratorDatas(string name, string begintime, string statime, string card, int pageindex, int pagesize)
        {
            return dataDal.GetAdministratorDatas(name,begintime,statime,card,pageindex,pagesize);
        }
        /// <summary>
        /// 添加经纪人信息
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public int Addadmin(AdministratorData d)
        {
            return dataDal.Addadmin(d);
        }

        /// <summary>
        /// 修改经纪人信息
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <param name="apost">职位</param>
        /// <param name="aid"></param>
        /// <returns></returns>
        public int UpdateAdmin(string phone, string apost, int aid)
        {
            return dataDal.UpdateAdmin(phone,apost,aid);
        }

        public List<AdministratorData> SeleAdministr(int ids)
        {
            return dataDal.SeleAdministr(ids);
        }
        public List<AdministratorData> SAdministr()
        {
            return dataDal.SAdministr();
        }
    }
}
