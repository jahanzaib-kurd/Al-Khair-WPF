using AlKhair.Models.DatabaseModels;
using ALKhair.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALKhair.BAL
{
    public static class BusinessModelParser
    {
        public static List<Area> GetAreas()
        {
            return Repository.GetAreas();
        }
    }
}
