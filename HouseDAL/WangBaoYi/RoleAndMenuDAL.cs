using DAL;
using HouseModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;

namespace HouseDAL.WangBaoYi
{
    public class RoleAndMenuDAL
    {
        #region 显示
        /// <summary>
        /// 角色下拉
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        public List<Rolese> ShowRole(Rolese rolese)
        {
            SqlParameter[] para = new SqlParameter[] { };
            var dt = DBHelper.GetTable("proc_ShowRole", para);
            var str = JsonConvert.SerializeObject(dt);
            var list = JsonConvert.DeserializeObject<List<Rolese>>(str);
            return list;
        }

        #endregion
        #region 添加
        /// <summary>
        /// 添加角色
        /// </summary>
        /// <param name="rolese"></param>
        /// <returns></returns>
        public int AddRole(Rolese rolese)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@RName", rolese.RName),
            };
            var success = DBHelper.AddUpdateDelte("proc_AddRole", para);
            return success;
        }
        #endregion
        #region 修改
        /// <summary>
        /// 修改角色
        /// </summary>
        /// <param name="rolese"></param>
        /// <returns></returns>
        public int ModifyRole(Rolese rolese)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@RId", rolese.RId),
                new SqlParameter("@RName", rolese.RName),
            };
            var success = DBHelper.AddUpdateDelte("proc_ModifyRole", para);
            return success;
        }
        #endregion
        #region 删除
        /// <summary>
        /// 删除角色
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        public int DeleteRole(Rolese rolese)
        {
            SqlParameter[] para = new SqlParameter[]
            {
              new SqlParameter("@RId", rolese.RId),
            };
            var success = DBHelper.AddUpdateDelte("proc_DeleteRole", para);
            return success;
        }
        #endregion
    }
}
