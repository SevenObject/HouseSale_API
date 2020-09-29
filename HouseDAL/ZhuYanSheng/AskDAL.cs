using DAL;
using HouseModel;
using System.Collections.Generic;

namespace HouseDAL.ZhuYanSheng
{
    public class AskDAL
    {
        public List<AdministratorData> GetAdmins(int AId)
        {
            string sql = "select a.* from AdministratorData a join HouseInfo h on a.AId = h.HTId where 1=1 ";
            if (AId != 0)
            {
                sql += $" and h.HTId={AId}";
            }
            return DBHelper.GetToList<AdministratorData>(sql);
        }
        public List<v_HouseInfos> GetHouse()
        {
            string sql = "select hoi.HTSId,hoi.HTSName,hoi.HTSPrice,hoi.HTPictures,hi.SellState,hi.ProjictSite,ht.HNames,ht.HouseArea,ht.Orientation,hts.TName,hts.TFloor from HouseInfo hi join HouseInfos hoi on hi.HTId=hoi.HTId join HousType ht on hoi.HId=ht.HId join HouseTypes hts on hoi.TId=hts.TId where hi.SellState like '%在售'";
            return DBHelper.GetToList<v_HouseInfos>(sql);
        }

    }
}