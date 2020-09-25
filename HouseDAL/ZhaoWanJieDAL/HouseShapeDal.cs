using System;
using System.Collections.Generic;
using System.Text;
using HouseModel;
using System.Linq;

namespace HouseDAL.ZhaoWanJieDAL
{
  public  class HouseShapeDal
    {
        DBHelper db = new DBHelper();

        /// <summary>
        /// 显示房间信息
        /// </summary>
        /// <param name="aid">根据经纪人</param>
        /// <param name="tation">朝向</param>
        /// <param name="hid">户型</param>
        /// <param name="htid">楼盘</param>
        /// <returns></returns>
        public ShapePage GetHouseShapes(int aid,string tation,int hid,int htid,int pageindex,int pagesize)
        {
            string sql = $"select * from HouseInfo s join HousType h on s.HTId=h.HTId join HouseShape u on h.HId=u.HId join AdministratorData a on u.AId=a.AId where u.HouseState=0 ";
            if (aid>0)
            {
                sql += $"and a.AId='{aid}' order by u.HSId desc";
            }
            if (!string.IsNullOrEmpty(tation))
            {
                sql += $"and h.Orientation='{tation}' order by u.HSId desc";
            }
            if (hid>0)
            {
                sql += $"and h.HId='{hid}' order by u.HSId desc";
            }
            if (htid>0)
            {
                sql += $"and s.HTId='{htid}' order by u.HSId desc";
            }
            var list = db.GetToList<HouseShape>(sql);
            if (pageindex < 1)
            {
                pageindex = 1;
            }
            var count = list.Count;
            int pagecount = 0;
            if (count%pagesize==0)
            {
                pagecount = count / pagesize;
            }
            if (count % pagesize != 0)
            {
                pagecount = count / pagesize + 1;
            }
            if (pageindex>pagecount)
            {
                pageindex = pagecount;
            }
            ShapePage s = new ShapePage();
            list = list.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
            s.houseShapes = list;
            s.pageCount = pagecount;
            s.pageIndex = pageindex;
            s.pageSize = pagesize;
            s.allCount = count;
            return s;
        }

        /// <summary>
        /// 添加房间信息
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public int AddHouseShape(HouseShape s)
        {
            string sql = $"insert into HouseShape values ('{s.HNumber}','{s.HousePicture}','{s.AveragePrice}','{s.HouseState}','{s.AId}','{s.HId}','{s.HTId}','{s.BeginTime}')";
            return db.ExecuteNonQuery(sql);
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
        public int UpdateHouseShape(string price,int state,int aid,int hid,int htid,int hsid)
        {
            string sql = $"update HouseShape set AveragePrice='{price}',HouseState='{state}',AId='{aid}',HId='{hid}',HTId='{htid}' where HSId='{hsid}'";
            return db.ExecuteNonQuery(sql);
        }
        public ShapePage SeleShape(int ids,int pageindex,int pagesize)
        {
            string sql = $"select * from HouseInfo s join HousType h on s.HTId=h.HTId join HouseShape u on h.HId=u.HId join AdministratorData a on u.AId=a.AId where h.HId='{ids}'";
            var list = db.GetToList<HouseShape>(sql);

            if (pageindex < 1)
            {
                pageindex = 1;
            }
            var count = list.Count;
            int pagecount = 0;
            if (count % pagesize == 0)
            {
                pagecount = count / pagesize;
            }
            if (count % pagesize != 0)
            {
                pagecount = count / pagesize + 1;
            }
            if (pageindex > pagecount)
            {
                pageindex = pagecount;
            }
            ShapePage s = new ShapePage();
            list = list.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
            s.houseShapes = list;
            s.pageCount = pagecount;
            s.pageIndex = pageindex;
            s.pageSize = pagesize;
            s.allCount = count;
            return s;
        }
    }
}
