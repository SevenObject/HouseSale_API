using DAL;
using HouseModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace HouseDAL.WangBaoYi
{
    public class ContractDAL
    {
        #region  显示
        /// <summary>
        /// 显示合同列表
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        public List<ContractData> ShowConList(ContractData contract)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@ContractCode",contract.ContractCode),
                new SqlParameter("@pageIndex",contract.PageIndex),
                new SqlParameter("@pageSize",contract.PageSize),
                new SqlParameter("@TotalCount",SqlDbType.Int),
                new SqlParameter("@TotalPage",SqlDbType.Int),
            };
            para[3].Direction = ParameterDirection.Output;//输出参数类型
            para[4].Direction = ParameterDirection.Output;//输出参数类型

            var dt = DBHelper.GetTable("proc_ShowConPage", para);

            var str = JsonConvert.SerializeObject(dt);
            var list = JsonConvert.DeserializeObject<List<ContractData>>(str);
            if (list.Count > 0)
            {
                list.FirstOrDefault().TotalCount = int.Parse(para[3].Value.ToString());
                list.FirstOrDefault().TotalPage = int.Parse(para[4].Value.ToString());
            }
            return list;


        }
        /// <summary>
        /// 显示合同信息
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        public List<ContractData> ShowCon(ContractData contract)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@CId",contract.CId),
            };
            var dt = DBHelper.GetTable("proc_ShowCon", para);
            var str = JsonConvert.SerializeObject(dt);
            var list = JsonConvert.DeserializeObject<List<ContractData>>(str);
            return list;
        }
        /// <summary>
        /// 预购买房产的编号
        /// </summary>
        /// <param name="shape"></param>
        /// <returns></returns>
        public List<HouseShape> ShowHouseShape(HouseShape shape)
        {
            SqlParameter[] para = new SqlParameter[] {
                new SqlParameter("@HSId",shape.HSId)
            };
            var dt = DBHelper.GetTable("proc_ShowRole", para);
            var str = JsonConvert.SerializeObject(dt);
            var list = JsonConvert.DeserializeObject<List<HouseShape>>(str);
            return list;
        }
        #endregion
        #region 添加
        /// <summary>
        /// 添加合同信息表
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        public int AddCon(ContractData contract)
        {
            SqlParameter[] para = new SqlParameter[]
            {
                new SqlParameter("@AName", contract.AName),
                new SqlParameter("@CName", contract.CName),
                new SqlParameter("@HSId", contract.HSId),
                new SqlParameter("@PriceUp", contract.PriceUp),
                new SqlParameter("@Pricedown", contract.Pricedown),
                new SqlParameter("@FirstBuyUp", contract.FirstBuyUp),
                new SqlParameter("@WorkDate", contract.WorkDate),
                new SqlParameter("@PlaneNumber", contract.PlaneNumber),
                new SqlParameter("@SealPicture", contract.SealPicture),
                new SqlParameter("@FirstBuyDown", contract.FirstBuyDown),
                new SqlParameter("@ContractCode", contract.ContractCode),
            };
            var success = DBHelper.AddUpdateDelte("proc_AddCon", para);
            return success;
        }
        #endregion
        #region 修改
        public int ModifyHouseState(int Id)
        {
            var sql = "update HouseShape set";
            if (Id > 0)
            {
                sql += $" HouseState = 1 where HSId=" + Id;
            }
            return DBHelper.ExecuteNonQuery(sql);
        }
        #endregion
        #region 删除
        /// <summary>
        /// 120行 删除合同
        /// </summary>
        /// <param name="contract"></param>
        /// <returns></returns>
        public int DeleteCon(ContractData contract)
        {
            SqlParameter[] para = new SqlParameter[]
            {
              new SqlParameter("@CId", contract.CId),
            };
            var success = DBHelper.AddUpdateDelte("proc_DelCon", para);
            return success;
        }
        /// <summary>
        /// 批删
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int DelAll(string id = "0")
        {
            string[] datalist = id.Split(',');//定义数组
            List<string> list = new List<string>();
            foreach (var item in datalist)
            {
                string data = "'" + item.ToString() + "'";
                list.Add(data);
            }
            string sql = string.Format("delete from Table where Id in(" + string.Join(",", list) + ")", list);
            return DBHelper.ExecuteNonQuery(sql);
        }
        #endregion
    }
}
