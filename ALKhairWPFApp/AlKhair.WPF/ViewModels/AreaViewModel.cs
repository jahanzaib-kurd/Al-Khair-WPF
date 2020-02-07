using AlKhair.Models;
using ALKhair.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlKhair.WPF.ViewModels
{
    public class AreaCardViewModel
    {
        private Area _area;
        public AreaCardViewModel(string areaCode)
        {
            _area = BusinessModelParser.GetArea(areaCode);
        }
        public Area Area
        {
            get { return _area; }
        }

        public void SaveChanges()
        {
            BusinessModelParser.SaveArea(Area);
        }
    }
}
