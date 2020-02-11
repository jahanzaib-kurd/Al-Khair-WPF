using AlKhair.WPF.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace AlKhair.Models
{
    public class Area : ObservableObject, IDataErrorInfo
    {


        #region Private Members
        private int _ID;
        private string _Code;
        private string _Name;
        private string _Description;
        private DateTime? _CreatedOn;
        private DateTime? _ModifiedOn;
        private bool? _IsActive;

        public string this[string columnName]
        {
            get
            {
                switch (columnName)
                {
                    case "Code":
                        if (string.IsNullOrWhiteSpace(Code))
                            return "Code cannot be empty";
                        break;

                    case "Name":
                        if (string.IsNullOrWhiteSpace(Name))
                            return "Name cannot be empty";
                        break;
                }
                return null;
            }
        }

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
                SetProperty(ref _Code, value);
            }
        }

        public string Name
        {
            get { return _Name; }
            set
            {
                SetProperty(ref _Name, value);
            }
        }

        public string Description
        {
            get { return _Description; }
            set
            {
                SetProperty(ref _Description, value);
            }
        }

        public DateTime? CreatedOn
        {
            get { return _CreatedOn; }
            set
            {
                SetProperty(ref _CreatedOn, value);
            }
        }

        public DateTime? ModifiedOn
        {
            get { return _ModifiedOn; }
            set
            {
                SetProperty(ref _ModifiedOn, value);
            }
        }

        public bool? IsActive
        {
            get { return _IsActive; }
            set
            {
                SetProperty(ref _IsActive, value);
            }
        }

        public string Error
        {
            get
            {
                return null;
            }
        }

        #endregion
    }
}
