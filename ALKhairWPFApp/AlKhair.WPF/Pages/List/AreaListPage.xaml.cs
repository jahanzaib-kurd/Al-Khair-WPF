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
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace AlKhair.WPF.Pages.List
{
    /// <summary>
    /// Interaction logic for AreaListPage.xaml
    /// </summary>
    public partial class AreaListPage : Page,INotifyPropertyChanged
    {
        private ObservableCollection<Area> _areaList = null;

        private string _filterString;

        public event PropertyChangedEventHandler PropertyChanged;

        public AreaListPage()
        {
            InitializeComponent();
            GetRecords();
        }

        public ObservableCollection<Area> Areas
        {
            get { return _areaList; }
            set
            {
                if (_areaList == null)
                    _areaList = new ObservableCollection<Area>();
                _areaList = value;
            }
        }

        private void btnCancel_Click(object sender, RoutedEventArgs e)
        {
            AreaGrid.SelectedItem = null;

        }

        private void btnSave_Click(object sender, RoutedEventArgs e)
        {
            // UPDATE
            Area model = null;
            if (AreaGrid.SelectedItem != null)
            {
                model = (Area)AreaGrid.SelectedItem;
            }
            else
            {
                model = new Area()
                {
                    Code = txtAreaCode.Text,
                    Name = txtAreaName.Text,
                    Description = txtDescription.Text,
                    IsActive = chkIsActive.IsChecked,
                    CreatedOn = DateTime.Now
                };
            }

            BusinessModelParser.SaveArea(model);
            Areas.Add(model);
        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (AreaGrid.SelectedItem != null)
            {
                BusinessModelParser.RemoveArea(((Area)AreaGrid.SelectedItem).Code);
                Areas.Remove((Area)AreaGrid.SelectedItem);
            }

        }

        private void GetRecords()
        {
            _areaList = new ObservableCollection<Area>(BusinessModelParser.GetAreas());
            _areaList.CollectionChanged += this.OnCollectionChanged;
        }

        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            //Get the sender observable collection
            ObservableCollection<Area> obsSender = sender as ObservableCollection<Area>;
            NotifyCollectionChangedAction action = e.Action;
        }
    }
}
