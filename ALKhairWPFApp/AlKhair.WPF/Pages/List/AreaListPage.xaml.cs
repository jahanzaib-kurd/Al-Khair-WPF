using AlKhair.Models;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using AlKhair.WPF.Windows.Card;
namespace AlKhair.WPF.Pages.List
{
    /// <summary>
    /// Interaction logic for AreaListPage.xaml
    /// </summary>
    public partial class AreaListPage : Page
    {
        public AreaListPage()
        {
            InitializeComponent();
            LoadData();
        }
        private void LoadData()
        {
            dgArea.DataContext = BusinessModelParser.GetAreas();

        }

        private void OnAreaCodeLink_Click(object sender, RoutedEventArgs e)
        {
            Button areaCode = (Button)sender;
            var card = new AreaCardPage(areaCode.Tag as string);
            card.Show();
        }
    }
}
