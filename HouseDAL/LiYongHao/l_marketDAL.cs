using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using DAL;
using HouseModel;
namespace HouseDAL.LiYongHao
{
   public class l_marketDAL
    {
            //房产销售显示
            public List<HouseSal> Show_market()
            {
             string sql= "select a.AName,c.HName,d.HNames,f.HNumber,e.CName,b.SaleDateTime,b.WriteOkDatetime,f.HouseState from AdministratorData a join HouseSale b on a.AId=b.HouseSaleId join HouseInfo c on b.HouseSaleId= c.HTId join HousType d on d.HId=b.HouseSaleId join ClientData e on e.CId=b.HouseSaleId join HouseShape f on f.HSId=b.HouseSaleId";
            return DBHelper.GetToList<HouseSal>(sql);

           }
            //房产销售显示
            public List<HouseSal> Show_market2()
            {
            string sql= "select a.AName,c.HName,d.HNames,f.HNumber,e.CName,b.SaleDateTime,b.WriteOkDatetime,f.HouseState from AdministratorData a join HouseSale b on a.AId=b.HouseSaleId join HouseInfo c on b.HouseSaleId= c.HTId join HousType d on d.HId=b.HouseSaleId join ClientData e on e.CId=b.HouseSaleId join HouseShape f on f.HSId=b.HouseSaleId where f.HouseState=1";
            return DBHelper.GetToList<HouseSal>(sql); 
            }
        //房产未销售显示
        public List<HouseSal> Show_market3()
        {
            string sql = "select a.AName,c.HName,d.HNames,f.HNumber,e.CName,b.SaleDateTime,b.WriteOkDatetime,f.HouseState from AdministratorData a join HouseSale b on a.AId=b.HouseSaleId join HouseInfo c on b.HouseSaleId= c.HTId join HousType d on d.HId=b.HouseSaleId join ClientData e on e.CId=b.HouseSaleId join HouseShape f on f.HSId=b.HouseSaleId where f.HouseState=0";
            return DBHelper.GetToList<HouseSal>(sql);
        }

        //房产预定显示
        public List<HouseSal> Show_market4()
        {
            string sql = "select a.AName,c.HName,d.HNames,f.HNumber,e.CName,b.SaleDateTime,b.WriteOkDatetime,f.HouseState from AdministratorData a join HouseSale b on a.AId=b.HouseSaleId join HouseInfo c on b.HouseSaleId= c.HTId join HousType d on d.HId=b.HouseSaleId join ClientData e on e.CId=b.HouseSaleId join HouseShape f on f.HSId=b.HouseSaleId where f.HouseState=3";
            return DBHelper.GetToList<HouseSal>(sql);
        }
        //退房登记
        public List<CheckOutContext> Show_check()
        {
            string sql = "select d.AName,b.CName,c.HNames,a.OutDatetime,a.OutHouseCause,a.OutHouseState from CheckOutContext a join ClientData  b on a.CId=b.CId join HousType  c on a.CId=c.HId join AdministratorData d on a.CId=d.AId";
            return DBHelper.GetToList<CheckOutContext>(sql);
        }
        //修改
        public int upt(int id)
        {
            string sql = $"update CheckOutContext set OutHouseState=3 where Cid='{id}'";
            return DBHelper.ExecuteNonQuery(sql);
        }

    }
}
