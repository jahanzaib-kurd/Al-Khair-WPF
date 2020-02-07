using AlKhair.Models;
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

        public static void SaveArea(Area area)
        {
            using (var context = new AlKhairDBContext())
            {
                var record = context.Areas.SingleOrDefault(x => x.Code == area.Code);
                if (record != null)
                {
                    record.Name = area.Name;
                    record.Description = area.Description;
                    record.IsActive = area.IsActive;
                    record.ModifiedOn = DateTime.Now;
                }
                else
                {
                    context.Areas.Add(area);
                }

                context.SaveChanges();
            }
        }

        public static void DeleteArea(string areaCode)
        {
            using (var context = new AlKhairDBContext())
            {
                var record = context.Areas.SingleOrDefault(x => x.Code == areaCode);
                if (record != null)
                {
                    context.Areas.Remove(record);
                    context.SaveChanges();
                }
            }
        }
    }
}
