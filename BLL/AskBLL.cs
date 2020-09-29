
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using HouseDAL.ZhuYanSheng;
using HouseModel;
using System.Text;

namespace HouseBLL
{
    public  class AskBLL
    {
        AskDAL dal = new AskDAL();
        public List<AdministratorData> GetAdmins(int aid)
        {
            return dal.GetAdmins(aid);
        }
        public List<v_HouseInfos> GetHouse()
        {
            return dal.GetHouse();
        }
    }
}