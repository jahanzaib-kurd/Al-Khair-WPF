using AlKhair.Models.DatabaseModels;
using ALKhair.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AlKhair.WPF.Windows.Card
{
    /// <summary>
    /// Interaction logic for AreaCardPage.xaml
    /// </summary>
    public partial class AreaCardPage : Window
    {
        private Area area = null;
        public AreaCardPage()
        {
            InitializeComponent();
        }

        public AreaCardPage(string areaCode)
        {
            InitializeComponent();
            area = BusinessModelParser.GetArea(areaCode);
            DataContext = area;
        }
    }
}
