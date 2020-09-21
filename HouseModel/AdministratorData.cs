using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace HouseModel
{
    public class AdminPage
    {
        public int pageIndex { get; set; }//页码
        public int pageSize { get; set; }//条数
        public int pageCount { get; set; }//总页数
        public int allCount { get; set; }//总条数
        public List<AdministratorData>  administratorDatas { get; set; }
    }

    /// <summary>
    /// 管理员资料表
    /// </summary>
    public class AdministratorData
    {
         
        /// <summary>
        /// 管理员资料主键
        /// </summary>
        public int AId { get; set; }
        /// <summary>
        /// 管理员姓名
        /// </summary>
        public string AName { get; set; }
        /// <summary>
        /// 管理员手机号
        /// </summary>
        public decimal APlaneNumber { get; set; }
        /// <summary>
        /// 身份证件号
        /// </summary>
        public decimal Card { get; set; }
        /// <summary>
        /// 入职时间
        /// </summary>
        public DateTime BeginTime { get; set; }
        /// <summary>
        /// 管理员照片
        /// </summary>
        public string APicture { get; set; }
        /// <summary>
        /// 管理员职位
        /// </summary>
        public string APosition { get; set; }
        /// <summary>
        /// 公司员工证件号
        /// </summary>
        public int CompanyCard { get; set; }
        /// <summary>
        /// 所属公司
        /// </summary>
        public string Company { get; set; }
        /// <summary>
        /// 管理员密码
        /// </summary>
        public string Password { get; set; }
    }
}
