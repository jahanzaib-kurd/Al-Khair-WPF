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
        //public static AlKhairDBContext dbContext = new AlKhairDBContext();
        public static List<Area> GetAreas()
        {
            using (var context = new AlKhairDBContext())
            {
                return context.Areas.ToList();
            }
        }
        public static Area GetArea(string areaCode)
        {
            using (var context = new AlKhairDBContext())
            {
                var query = from a in context.Areas
                            where a.Code == areaCode
                            select a;

                return query.FirstOrDefault<Area>();
            }
        }
    }
}
