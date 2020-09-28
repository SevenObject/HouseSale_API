using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HouseModel;

namespace HouseDAL.ZhaoWanJieDAL
{
   public class HouseInfoDal
    {
        DBHelper db = new DBHelper();

        /// <summary>
        /// 显示楼盘信息
        /// </summary>
        /// <param name="hname">根据楼盘名称</param>
        /// <param name="htptime">根据开盘时间到</param>
        /// <param name="hantime">交房时间</param>
        /// <param name="pageindex">第几页</param>
        /// <param name="pagesize">每页几条</param>
        /// <returns></returns>
        public Page GetHouseInfos(string hname,string htptime,string hantime, int pageindex,int pagesize)
        {
            string sql = $"select * from HouseInfo where AddressId=0";
            if (!string.IsNullOrEmpty(hname))
            {
                sql += $"and HName like '%{hname}%'";
            }
            //if (!string.IsNullOrEmpty(htptime)||!string.IsNullOrEmpty(hantime))
            //{
            //    sql += $"and HTPDateTime>='{htptime}' and HandHouseTime<='{hantime}'";
            //}
            if (!string.IsNullOrEmpty(htptime))
            {
                sql += $"and HTPDateTime>='{htptime}'";
            }
            if (!string.IsNullOrEmpty(hantime))
            {
                sql += $"and HandHouseTime<='{hantime}'";
            }
            sql += "order by HTId desc";
            var list = db.GetToList<HouseInfo>(sql);
            if (pageindex<1)
            {
                pageindex = 1;
            }
            var count = list.Count;
            int pagecout = 0;
            if (count% pagesize == 0)
            {
                pagecout = count / pagesize;
            }
            if (count% pagesize != 0)
            {
                pagecout = count / pagesize + 1;
            }
            if (pageindex>pagecout)
            {
                pageindex = pagecout; 
            }
            Page p = new Page();
            list = list.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
            p.houseInfos = list;
            p.pageCount = pagecout;
            p.pageIndex = pageindex;
            p.pageSize = pagesize;
            p.allCount = count;
            return p;
        }
        /// <summary>
        /// 删除楼盘
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public int DeleHouseInfo(int ids)
        {
            string sql = $"update HouseInfo set AddressId=1 where HTId='{ids}'";
            return db.ExecuteNonQuery(sql);
        }
        /// <summary>
        /// 修改楼盘信息
        /// </summary>
        /// <param name="sellstate">销售状态</param>
        /// <param name="handtime">交房时间</param>
        /// <param name="handtime">周边规划</param>
        /// <returns></returns>
        public int UpdateHouseInfo(string sellstate,string handtime,string rim, int ids)
        {
            string sql = $"update HouseInfo set SellState='{sellstate}',HandHouseTime='{handtime}',Rim='{rim}' where HTId='{ids}'";
            return db.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 添加楼盘信息
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public int AddHouseInfo(HouseInfo h)
        {
            string sql = $"insert into HouseInfo values ('{h.HName}','{h.HTPicture}','{h.HTPDateTime}','{h.ProjictSite}','{h.SellHouse}','{h.developers}','{h.SellState}','{h.Architecturearea}','{h.HandHouseTime}','{h.YearAstrict}','{h.HouseStates}','{h.Plot}','{h.Greeningrate}','{h.Rim}')";
            return db.ExecuteNonQuery(sql);
        }

        public List<HouseInfo>SeleHouInfo()
        {
            string sql = "select * from HouseInfo";
            return db.GetToList<HouseInfo>(sql);
        }
        public List<HouseInfo> UpdateAddHouInfo(int ids)
        {
            string sql = $"select * from HouseInfo where HTId='{ids}'";
            return db.GetToList<HouseInfo>(sql);
        }
    }
}
