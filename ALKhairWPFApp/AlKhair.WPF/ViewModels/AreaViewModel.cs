using AlKhair.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using AlKhair.WPF.Commands;
using ALKhair.DAL;
using ALKhair.BAL;
using System.ComponentModel;

namespace AlKhair.WPF.ViewModels
{
    public class AreaViewModel : INotifyPropertyChanged
    {
        private ObservableCollection<Area> _areaList = null;
        private Area newArea;
        private string _filterString;
        private string _statusString;

        public AreaViewModel()
        {
            _areaList = new ObservableCollection<Area>(BusinessModelParser.GetAreas());
            //_areaList.CollectionChanged += this.OnCollectionChanged;
            _saveAreaCommand = new SaveAreaCommand(newArea);
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

        public string FilterString
        {
            get { return _filterString; }
            set { _filterString = value; }
        }
        public string StatusString
        {
            get { return _statusString; }
            set { _statusString = value; }
        }

        ICommand _saveAreaCommand;


        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;

            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        #endregion
    }
}
