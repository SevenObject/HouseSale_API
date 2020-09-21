using System;
using System.Collections.Generic;
using System.Text;
using HouseDAL.ZhaoWanJieDAL;
using HouseModel;

namespace HouseBLL.ZhaoWanJieBLL
{
   public class ClientDataBll
    {
        ClientDataDal Clientd = new ClientDataDal();

        /// <summary>
        /// 经纪人只能查看自己所属的客户
        /// </summary>
        /// <param name="aid"></param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <param name="daikan"></param>
        /// <returns></returns>
        public ClienPage GetClientDatas(int aid, int pageindex, int pagesize, int daikan)
        {
            return Clientd.GetClientDatas(aid,pageindex,pagesize,daikan);
        }
        /// <summary>
        /// 添加客户信息
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int AddClient(ClientData c)
        {
            return Clientd.AddClient(c);
        }
    }
}
