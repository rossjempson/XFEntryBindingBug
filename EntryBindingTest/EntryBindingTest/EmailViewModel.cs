using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntryBindingTest
{
    public class EmailViewModel : INotifyPropertyChanged
    {

        public EmailViewModel()
        {
            _isEnabled = true;
            ReceiversEmail = string.Empty;
            ReceiversName = string.Empty;
            ExpectedQty = 11;
        }

        private bool _isEnabled;

        public bool IsEnabled
        {
            get { return _isEnabled; }
            set
            {
                _isEnabled = value;
                OnPropertyChanged("IsEnabled");
            }
        }

        private string _email;
        public string ReceiversEmail
        {
            get { return _email; }
            set
            {
                _email = value;
                OnPropertyChanged("ReceiversEmail");
            }
        }

        private string _name;
        public string ReceiversName
        {
            get { return _name; }
            set
            {
                _name = value;
                OnPropertyChanged("ReceiversName");
            }
        }

        private decimal _expectedQty = 0;

        public decimal ExpectedQty
        {
            get { return _expectedQty; }
            set
            {
                _expectedQty = value;
                OnPropertyChanged("ExpectedQty");
            }
        }

        #region INotifyPropertyChanged implementation

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        public void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged == null)
                return;

            PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
