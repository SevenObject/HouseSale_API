using DAL;
using HouseModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HouseDAL.FengLuShun
{
    public class HouseInfoDAL
    {
        //显示主页面需要的数据
        //public List<HouseInfos> GetHouse(string name)
        //{
        //    string sql = "select hoi.HTSId,hoi.HTSName,hoi.HTSPrice,hoi.HTPictures,hi.SellState,hi.ProjictSite,ht.HNames,ht.HouseArea,ht.Orientation,hts.TName,hts.TFloor from HouseInfo hi join HouseInfos hoi on hi.HTId=hoi.HTId join HousType ht on hoi.HId=ht.HId join HouseTypes hts on hoi.TId=hts.TId where 1=1 ";
        //    if (!string.IsNullOrEmpty(name))
        //    {
        //        sql+=$" and hi.ProjictSite like'%{name}%' or hts.TName like'%{name}%'";
        //    }
        //    return DBHelper.GetToList<HouseInfos>(sql);
        //}
        //显示主页面需要的数据
        public List<HouseInfos> GetHouse(string name)
        {
            string sql = "select hoi.HTSId,hoi.HTSName,hoi.HTSPrice,hoi.HTPictures,hi.SellState,hi.ProjictSite,ht.HNames,ht.HouseArea,ht.Orientation,hts.TName,hts.TFloor from HouseInfo hi join HouseInfos hoi on hi.HTId=hoi.HTId join HousType ht on hoi.HId=ht.HId join HouseTypes hts on hoi.TId=hts.TId where 1=1 ";
            if (!string.IsNullOrEmpty(name))
            {
                sql += $" and hi.ProjictSite like'%{name}%' or hts.TName like'%{name}%'";
            }
            return DBHelper.GetToList<HouseInfos>(sql);
            //var list=DBHelper.GetToList<HouseInfos>(sql);
            //if (pageindex<1)
            //{
            //    pageindex = 1;
            //}
            //var count = list.Count;
            //int pagecount = 0;

            //if (count % pagesize == 0)
            //{
            //    pagecount = count / pagesize;
            //}
            //if (count% pagesize != 0)
            //{
            //    pagecount = count / pagesize + 1;
            //}
            //if (pageindex>pagecount)
            //{
            //    pageindex = pagecount;
            //}
            //Page p = new Page();
            //list = list.Skip((pageindex - 1) * pagesize).Take(pagesize).ToList();
            //p.houseInfos = list;
            //p.pageCount = pageindex;
            //p.pageIndex = pageindex;
            //p.pageSize = pagesize;
            //p.allCount = count;
            //return p;

        }
        //房子详情页
        public HouseInfos Particulars(int id)
        {
            string sql = $"select ig.Imges,hoi.HTSId,hoi.HTSName,hoi.HTSPrice,hoi.HTPictures,hi.Greeningrate,hi.SellState,hi.ProjictSite,ht.HNames,ht.HouseArea,ht.Orientation,hts.TName,hts.TFloor from HouseInfo hi join HouseInfos hoi on hi.HTId=hoi.HTId join HousType ht on hoi.HId=ht.HId join HouseTypes hts on hoi.TId=hts.TId join Imgs ig on ig.HTSId=hoi.HTSId where hoi.HTSId={id}";
            return DBHelper.Get<HouseInfos>(sql);
        }
        //public List<HouseInfos> Particulars(int id)
        //{
        //    string sql = $"select ig.Imges,hoi.HTSId,hoi.HTSName,hoi.HTSPrice,hoi.HTPictures,hi.Greeningrate,hi.SellState,hi.ProjictSite,ht.HNames,ht.HouseArea,ht.Orientation,hts.TName,hts.TFloor from HouseInfo hi join HouseInfos hoi on hi.HTId=hoi.HTId join HousType ht on hoi.HId=ht.HId join HouseTypes hts on hoi.TId=hts.TId join Imgs ig on ig.HTSId=hoi.HTSId where hoi.HTSId={id}";
        //    return DBHelper.GetToList<HouseInfos>(sql);
        //}
        public List<HouseInfos> HouseImg(int id)
        {
            string sql = $"select ims.Imges,hoi.HTSId from Imgs ims join HouseInfos hoi on ims.HTSId=hoi.HTSId where hoi.HTSId={id}";
            return DBHelper.GetToList<HouseInfos>(sql);
        }
    }
}