using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlKhair.Models
{
    public class Area : INotifyPropertyChanged
    {


        #region Private Members
        private int _ID;
        private string _Code;
        private string _Name;
        private string _Description;
        private DateTime? _CreatedOn;
        private DateTime? _ModifiedOn;
        private bool? _IsActive;
        #endregion

        #region Public Members
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID
        {
            get { return _ID; }
            set { _ID = value; }
        }

        [StringLength(50)]
        [Index(IsUnique = true)]
        public string Code
        {
            get { return _Code; }
            set
            {
                _Code = value;
                OnPropertyChanged("Code");
            }
        }

        public string Name
        {
            get { return _Name; }
            set
            {
                _Name = value;
                OnPropertyChanged("Name");
            }
        }

        public string Description
        {
            get { return _Description; }
            set
            {
                _Description = value;
                OnPropertyChanged("Description");
            }
        }

        public DateTime? CreatedOn
        {
            get { return _CreatedOn; }
            set
            {
                _CreatedOn = value;

            }
        }

        public DateTime? ModifiedOn
        {
            get { return _ModifiedOn; }
            set
            {
                _ModifiedOn = value;
                OnPropertyChanged("ModifiedOn");
            }
        }

        public bool? IsActive
        {
            get { return _IsActive; }
            set
            {
                _IsActive = value;
                OnPropertyChanged("IsActive");
            }
        }

        #endregion

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
