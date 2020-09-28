using DAL;
using HouseModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace HouseDAL.WangBaoYi
{
    public class AdminDAL
    {
        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        public AdministratorData Login(string name, string pwd)
        {
            string sql = "select * from AdministratorData a where 1=1 ";
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(pwd))
            {
                sql += $" and a.AName like '%{name}%' and a.APassword like '%{pwd}%'";
            }
            return (AdministratorData)DBHelper.ExecuteScalar(sql);
        }
    }
}
