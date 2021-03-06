﻿using System;
using System.Collections.Generic;
using System.Text;
using HouseDAL.ZhaoWanJieDAL;
using HouseModel;

namespace HouseBLL.ZhaoWanJieBLL
{
   public class HouseInfoBll
    {
        HouseInfoDal infoDal = new HouseInfoDal();

        /// <summary>
        /// 显示楼盘信息
        /// </summary>
        /// <param name="hname">根据楼盘名称</param>
        /// <param name="htptime">根据开盘时间到</param>
        /// <param name="hantime">交房时间</param>
        /// <param name="pageindex">第几页</param>
        /// <param name="pagesize">每页几条</param>
        /// <returns></returns>
        public Page GetHouseInfos(string hname, string htptime, string hantime, int pageindex, int pagesize)
        {
            return infoDal.GetHouseInfos(hname,htptime,hantime,pageindex,pagesize);
        }
        /// <summary>
        /// 修改楼盘信息
        /// </summary>
        /// <param name="sellstate">销售状态</param>
        /// <param name="handtime">交房时间</param>
        /// <param name="handtime">周边规划</param>
        /// <returns></returns>
        public int UpdateHouseInfo(string sellstate, string handtime, string rim, int ids)
        {
            return infoDal.UpdateHouseInfo(sellstate,handtime,rim,ids);
        }
        /// <summary>
        /// 添加楼盘信息
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public int AddHouseInfo(HouseInfo h)
        {
            return infoDal.AddHouseInfo(h);
        }

        public int DeleHouseInfo(int ids)
        {
            return infoDal.DeleHouseInfo(ids);
        }
        public List<HouseInfo> SeleHouInfo()
        {
            return infoDal.SeleHouInfo();
        }
        public List<HouseInfo> UpdateAddHouInfo(int ids)
        {
            return infoDal.UpdateAddHouInfo(ids);
        }
    }
}
