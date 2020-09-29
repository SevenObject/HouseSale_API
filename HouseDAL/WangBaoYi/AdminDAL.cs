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
        public int Login(string name, string pwd)
        {
            string sql = "select a.AId from AdministratorData a where 1=1 ";
            if (!string.IsNullOrEmpty(name) && !string.IsNullOrEmpty(pwd))
            {
                sql += $" and a.AName = '{name}' and a.APassword ='{pwd}'";
            }
            return (int)DBHelper.ExecuteScalar(sql);
        }
        
    }
}
