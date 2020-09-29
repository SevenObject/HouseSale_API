using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseModel
{
    public class ClienPage
    {
        public int pageIndex { get; set; }//页码
        public int pageSize { get; set; }//条数
        public int pageCount { get; set; }//总页数
        public int allCount { get; set; }//总条数
        public List<ClientData>  clients { get; set; }
    }
    /// <summary>
    /// 客户资料表
    /// </summary>
    public class ClientData
    {
         
        /// <summary>
        /// 客户资料主键
        /// </summary>
        public int CId { get; set; }
        /// <summary>
        /// 客户姓名
        /// </summary>
        public string CName { get; set; }
        /// <summary>
        /// 客户手机号
        /// </summary>
        public string CPlaneNumber { get; set; }
        /// <summary>
        /// 客户首套
        /// </summary>
        public string ClientFirstHouse { get; set; }
        /// <summary>
        /// 客户贷款
        /// </summary>
        public string Clientloans { get; set; }
        /// <summary>
        /// 购房需求
        /// </summary>
        public string BuyHouseRole { get; set; }
        /// <summary>
        /// 是否带看
        /// </summary>
        public int DaiKan { get; set; }

        public int AId { get; set; }
        public string AName { get; set; }

        public int Cstates { get; set; }
    }
}
