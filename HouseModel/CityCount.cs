
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace HouseModel
{
   public  class CityCount
    {
        public int nowPage { get; set; }
        public int pageCount { get; set; }
        public int dataCount { get; set; }

        public List<v_HouseInfos> infos { get; set; }
    }
}