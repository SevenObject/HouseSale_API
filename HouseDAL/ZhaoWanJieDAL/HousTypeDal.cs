using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using HouseModel;

namespace HouseDAL.ZhaoWanJieDAL
{
   public class HousTypeDal
    {
        DBHelper db = new DBHelper();

        /// <summary>
        /// 显示户型信息
        /// </summary>
        /// <param name="pageindex"></param>
        /// <param name="pagesize"></param>
        /// <param name="htid">根据楼盘查询</param>
        /// <param name="orien">根据朝向</param>
        /// <param name="price">根据价格区间</param>
        /// <param name="prices">根据价格区间</param>
        /// <returns></returns>
        public Fen GetHousTypes(int pageindex, int pagesize,int htid,string orien,string price,string prices)
        {
            string sql = $"select * from HouseInfo s join HousType h on s.HTId=h.HTId where 1=1";
            if (htid>0)
            {
                sql += $"and HTId='{htid}'";
            }
            if (!string.IsNullOrEmpty(orien))
            {
                sql += $"and Orientation='{orien}'";
            }
             
            if (!string.IsNullOrEmpty(price))
            {
                sql += $"and h.PriceCount>='{price}'";
            }
            if (!string.IsNullOrEmpty(prices))
            {
                sql += $"and h.PriceCount<='{prices}'";
            }
            var list = db.GetToList<HousType>(sql);
            if (pageindex < 1)
            {
                pageindex = 1;
            }
            var count = list.Count;
            int pagecout = 0;
            if (count % pagesize == 0)
            {
                pagecout = count / pagesize;
            }
            if (count % pagesize != 0)
            {
                pagecout = count / pagesize + 1;
            }
            if (pageindex > pagecout)
            {
                pageindex = pagecout;
            }
            Fen f = new Fen();
            list = list.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
            f.housTypes = list;
            f.pageCount = pagecout;
            f.pageIndex = pageindex;
            f.pageSize = pagesize;
            f.allCount = count;
            return f;
        } 

        /// <summary>
        /// 添加户型信息
        /// </summary>
        /// <param name="h"></param>
        /// <returns></returns>
        public int AddHousType(HousType h)
        {
             
            string sql = $"insert into HousType values ('{h.HNames}','{h.HouseArea}','{h.PriceCount}','{h.HoousePicture}','{h.Orientation}','{h.HTId}','{h.BeginTime}')";
            return db.ExecuteNonQuery(sql);
        }

        /// <summary>
        /// 修改户型价格
        /// </summary>
        /// <param name="price"></param>
        /// <param name="hid"></param>
        /// <returns></returns>
        public int UpdateHousType(string price,int hid)
        {
            string sql = $"update HousType set PriceCount='{price}' where HId='{hid}'";
            return db.ExecuteNonQuery(sql);
        }

        public Fen Sel(int ids,int pageindex,int pagesize)
        {
            string sql = $"select * from HouseInfo s join HousType h on s.HTId = h.HTId where h.HTId='{ids}'";
            var list = db.GetToList<HousType>(sql);
            if (pageindex < 1)
            {
                pageindex = 1;
            }
            var count = list.Count;
            int pagecout = 0;
            if (count % pagesize == 0)
            {
                pagecout = count / pagesize;
            }
            if (count % pagesize != 0)
            {
                pagecout = count / pagesize + 1;
            }
            if (pageindex > pagecout)
            {
                pageindex = pagecout;
            }
            Fen f = new Fen();
            list = list.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
            f.housTypes = list;
            f.pageCount = pagecout;
            f.pageIndex = pageindex;
            f.pageSize = pagesize;
            f.allCount = count;
            return f;
        }
    }
}
