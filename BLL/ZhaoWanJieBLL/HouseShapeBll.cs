using System;
using System.Collections.Generic;
using System.Text;
using HouseDAL.ZhaoWanJieDAL;
using HouseModel;

namespace HouseBLL.ZhaoWanJieBLL
{
   public class HouseShapeBll
    {
        HouseShapeDal shapeDal = new HouseShapeDal();

        /// <summary>
        /// 显示房间信息
        /// </summary>
        /// <param name="name">根据经纪人</param>
        /// <param name="tation">朝向</param>
        /// <param name="hid">户型</param>
        /// <param name="htid">楼盘</param>
        /// <returns></returns>
        public ShapePage GetHouseShapes(int aid, string tation, int hid, int htid, int pageindex, int pagesize)
        {
            return shapeDal.GetHouseShapes(aid,tation,hid,htid,pageindex,pagesize);
        }

        /// <summary>
        /// 添加房间信息
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int AddHouseShape(HouseShape s)
        {
            return shapeDal.AddHouseShape(s);
        }

        /// <summary>
        /// 修改房间信息
        /// </summary>
        /// <param name="price">修改单价</param>
        /// <param name="state">修改放假状态</param>
        /// <param name="aid">修改经纪人</param>
        /// <param name="hid">修改户型</param>
        /// <param name="htid">修改楼盘</param>
        /// <param name="hsid"></param>
        /// <returns></returns>
        public int UpdateHouseShape(string price, int state, int aid, int hid, int htid, int hsid)
        {
            return shapeDal.UpdateHouseShape(price,state,aid,hid,htid,hsid);
        }
        public ShapePage SeleShape(int ids, int pageindex, int pagesize)
        {
            return shapeDal.SeleShape(ids,pageindex,pagesize);
        }
    }
}
