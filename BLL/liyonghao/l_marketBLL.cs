using System;
using System.Collections.Generic;
using System.Text;
using HouseModel;
using HouseDAL;
using HouseDAL.LiYongHao;

namespace HouseBLL.liyonghao
{
   public class l_marketBLL
    {
        l_marketDAL dal = new l_marketDAL();
        //房产销售显示
        public List<HouseSal> Show_market()
        {
            return dal.Show_market();
        }
        //房产未售显示
        public List<HouseSal> Show_market2()
        {
            return dal.Show_market2();
        }
        //退房登记显示
        public List<HouseSal> Show_market3()
        {
            return dal.Show_market3();
        }
        public List<HouseSal> Show_market4()
        {
            return dal.Show_market4();
        }
        //退房登记
        public List<CheckOutContext> Show_check()
        {
            return dal.Show_check();
        }
        //修改
        public int upt(int id)
        {
            return dal.upt(id);
        }

    }
}
