using AlKhair.Models.DatabaseModels;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALKhair.DAL
{
   public static class Repository
    {
        public static AlKhairDBContext dbContext = new AlKhairDBContext();
        public static List<Area> GetAreas()
        {
            return dbContext.Areas.ToList();
        }
    }
}
