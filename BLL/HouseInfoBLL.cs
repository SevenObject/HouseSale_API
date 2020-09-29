
using HouseDAL.FengLuShun;
using HouseModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HouseBLL
{
    public class HouseInfoBLL
    {
        HouseInfoDAL dal = new HouseInfoDAL();
        public List<HouseInfos> GetHouse(string name)
        {
            return dal.GetHouse(name);
        }
        //房子详情页
        public HouseInfos Particulars(int id)
        {
            return dal.Particulars(id);
        }
        public List<HouseInfos> HouseImg(int id)
        {
            return dal.HouseImg(id);
        }
    }
}