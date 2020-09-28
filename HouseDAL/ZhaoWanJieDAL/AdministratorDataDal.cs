using System;
using System.Collections.Generic;
using System.Text;
using HouseModel;
using System.Linq;

namespace HouseDAL.ZhaoWanJieDAL
{
   public class AdministratorDataDal
    {
        DBHelper db = new DBHelper();

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
        public AdminPage GetAdministratorDatas(string name,string begintime,string statime,string card,int pageindex,int pagesize)
        {
            string sql = $"select * from AdministratorData where 1=1";
            if (!string.IsNullOrEmpty(name))
            {
                sql += $"and AName like '%{name}%'";
            }
            if (!string.IsNullOrEmpty(begintime))
            {
                sql += $"and BeginTime<='{begintime}'";
            }
            if (!string.IsNullOrEmpty(statime))
            {
                sql += $"and BeginTime<='{statime}'";
            }
            //if (!string.IsNullOrEmpty(begintime)|| !string.IsNullOrEmpty(statime))
            //{
            //    sql += $"and BeginTime>='{begintime}'and BeginTime<='{statime}'";
            //}
            if (!string.IsNullOrEmpty(card))
            {
                sql += $"and CompanyCard='{card}'";
            }
            sql += "order by AId desc";
            var list = db.GetToList<AdministratorData>(sql);
            if (pageindex<1)
            {
                pageindex = 1;
            }
            var count = list.Count;
            int pagecount = 0;
            if (count% pagesize == 0)
            {
                pagecount = count / pagesize;
            }
            if (count% pagesize != 0)
            {
                pagecount = count / pagesize + 1;
            }
            if (pageindex>pagecount)
            {
                pageindex = pagecount;
            }
            AdminPage a = new AdminPage();
            list = list.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
            a.administratorDatas = list;
            a.pageCount = pagecount;
            a.pageIndex = pageindex;
            a.pageSize = pagesize;
            a.allCount = count;
            return a;
        }
        /// <summary>
        /// 添加经纪人信息
        /// </summary>
        /// <param name="d"></param>
        /// <returns></returns>
        public int Addadmin(AdministratorData d)
        {
            string sql = $"insert into AdministratorData values ('{d.AName}','{d.APlaneNumber}','{d.Card}','{d.BeginTime}','{d.APicture}','{d.APosition}','{d.CompanyCard}','{d.Company}')";
            return db.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 修改经纪人信息
        /// </summary>
        /// <param name="phone">手机号</param>
        /// <param name="apost">职位</param>
        /// <param name="aid"></param>
        /// <returns></returns>
        public int UpdateAdmin(string phone,string apost,int aid)
        {
            string sql = $"update AdministratorData set APlaneNumber='{phone}',APosition='{apost}' where AId='{aid}'";
            return db.ExecuteNonQuery(sql);
        }
        public  List<AdministratorData> SeleAdministr(int ids)
        {
            string sql = $"select * from AdministratorData where AId='{ids}'";
            return db.GetToList<AdministratorData>(sql);
        }
        public List<AdministratorData> SAdministr()
        {
            string sql = $"select * from AdministratorData";
            return db.GetToList<AdministratorData>(sql);
        }
    }
}
