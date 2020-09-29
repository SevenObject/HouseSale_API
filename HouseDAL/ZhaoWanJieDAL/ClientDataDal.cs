using System;
using System.Collections.Generic;
using System.Text;
using HouseModel;
using System.Linq;

namespace HouseDAL.ZhaoWanJieDAL
{
  public  class ClientDataDal
    {
        DBHelper db = new DBHelper();


        /// <summary>
        /// 经纪人只能查看自己所属的客户
        /// </summary>
        /// <param name="aid"></param>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <param name="daikan"></param>
        /// <returns></returns>
        public ClienPage GetClientDatas(int aid,int pageindex,int pagesize,int daikan,string name)
        {
            string sql = $"select * from ClientData  c join AdministratorData a on c.AId=a.AId where c.AId='{aid}' and c.Cstates=0";
             
            if (daikan>0)
            {
                sql += $"and DaiKan='{daikan}'";
            }
            if (daikan < 0)
            {
                sql += $"and DaiKan='{daikan}'";
            }
            if (!string.IsNullOrEmpty(name))
            {
                sql += $"and c.CName like '%{name}%'";
            }
            sql += "order by CId desc";
            var list = db.GetToList<ClientData>(sql);
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
            ClienPage p = new ClienPage();
            list = list.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
            p.clients = list;
            p.pageCount = pagecount;
            p.pageIndex = pageindex;
            p.pageSize = pagesize;
            p.allCount = count;
            return p;
        }
        /// <summary>
        /// 添加客户信息
        /// </summary>
        /// <param name="c"></param>
        /// <returns></returns>
        public int AddClient(ClientData c)
        {
            string sql = $"insert into ClientData values ('{c.CName}','{c.CPlaneNumber}','{c.ClientFirstHouse}','{c.Clientloans}','{c.BuyHouseRole}','{c.DaiKan}','{c.AId}')";
            return db.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 修改带看状态
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public int UpdateClient(int ids)
        {
            string sql = $"update ClientData set DaiKan=1 where CId='{ids}'";
            return db.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 改变删除状态
        /// </summary>
        /// <param name="ids"></param>
        /// <returns></returns>
        public int DeleClient(int ids)
        {
            string sql = $"update ClientData set Cstates=1 where CId='{ids}'";
            return db.ExecuteNonQuery(sql);
        }
    }
}
