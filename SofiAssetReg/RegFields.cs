using System.Collections.Generic;
using SofiAssetReg.Annotations;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace SofiAssetReg
{
    public class RegFields : INotifyPropertyChanged
    {
        private string _serial;
        private string _year;
        private string _model;
        private string _mac;
        private string _imei;
        private string _zwave;


        public RegFields()
        {
            _serial = "";
            _year = "";
            _model = "";
            _mac = "";
            _imei = "";
            _zwave = "";
        }

        public bool autoSerial = true;
        


        public string mac
        {
            get { return _mac; }
            set
            {
                _mac = value;
                OnPropertyChanged("mac");
            }
        }

        public string imei
        {
            get { return _imei; }
            set
            {
                _imei = value;
                OnPropertyChanged("imei");
            }
        }

        public string model
        {
            get { return _model; }
            set
            {
                _model = value;
                OnPropertyChanged("model");
            }
        }

        public string year
        {
            get { return _year; }
            set
            {
                _year = value;
                OnPropertyChanged("year");
            }
        }

  
        public string serial
        {
            set
            {
                _serial = value;
                OnPropertyChanged("serial");
            }

            get
            {
                if (autoSerial)
                    return mac.Replace(":", "") +"/"+ model;
                return _serial;
            }

        }

        public string zwave
        {
            get { return _zwave; }
            set
            {
                _zwave = value;
                OnPropertyChanged("zwave");
            }
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string property = null)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        public Dictionary<string, object> ToDictionary()
        {
           var result = this.GetType()
                .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                .ToDictionary(prop => prop.Name, prop => prop.GetValue(this, null));

            return result;
        }
    }


}