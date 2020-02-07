using AlKhair.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ALKhair.DAL
    
{
    public class AlKhairDBContext : DbContext
    {
        public DbSet<Area> Areas { get; set; }
    }
}
