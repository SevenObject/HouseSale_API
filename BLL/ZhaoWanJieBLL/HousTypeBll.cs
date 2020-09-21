using System;
using System.Collections.Generic;
using System.Text;
using HouseDAL.ZhaoWanJieDAL;
using HouseModel;

namespace HouseBLL.ZhaoWanJieBLL
{
   public class HousTypeBll
    {
        HousTypeDal houseDal = new HousTypeDal();

        /// <summary>
        /// 显示户型信息
        /// </summary>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <param name="htid">根据楼盘查询</param>
        /// <param name="orien">根据朝向</param>
        /// <param name="price">根据价格区间</param>
        /// <param name="prices">根据价格区间</param>
        /// <returns></returns>
        public Fen GetHousTypes(int pageindex, int pagesize, int htid, string orien, string price, string prices)
        {
            return houseDal.GetHousTypes(pageindex,pagesize,htid,orien,price,prices);
        }

        /// <summary>
        /// 添加户型信息
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public int AddHousType(HousType h)
        {
            return houseDal.AddHousType(h);
        }

        /// <summary>
        /// 修改户型价格
        /// </summary>
        /// <param name="price"></param>
        /// <param name="hid"></param>
        /// <returns></returns>
        public int UpdateHousType(string price, int hid)
        {
            return houseDal.UpdateHousType(price,hid);
        }

    }
}
