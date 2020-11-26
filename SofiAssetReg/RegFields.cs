using Nustache.Core;
using SofiAssetReg.Annotations;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;

namespace SofiAssetReg
{
    public class RegFields : INotifyPropertyChanged
    {
        private string _serial;
        private string _serialPrefix;
        private string _year;
        private string _model;
        private string _mac;
        private string _imei;
        private string _zwave;

        private string _serialFormat = "";

        private bool _initalised = false;


        public RegFields()
        {
            _serial = "";
            _serialPrefix = "";
            _year = "";
            _model = "";
            _mac = "";
            _imei = "";
            _zwave = "";
            _initalised = true;
        }

        public RegFields(string SerialFormat)
        {
            _serialFormat = SerialFormat;
            _serial = "";
            _serialPrefix = "";
            _year = "";
            _model = "";
            _mac = "";
            _imei = "";
            _zwave = "";
            _initalised = true;

        }

        public bool autoSerial = true;



        public string mac
        {
            get { return _mac; }
            set
            {
                _mac = value;
                if (_initalised)
                    OnPropertyChanged("mac");
            }
        }

        public string mac2
        {
            get { return _mac.Replace(":", ""); }
        }

        public string imei
        {
            get { return _imei; }
            set
            {
                _imei = value;
                if (_initalised)
                    OnPropertyChanged("imei");
            }
        }

        public string model
        {
            get { return _model; }
            set
            {
                _model = value;
                if (_initalised)
                    OnPropertyChanged("model");
            }
        }

        public string year
        {
            get { return _year; }
            set
            {
                _year = value;
                if (_initalised)
                    OnPropertyChanged("year");
            }
        }


        public string serialPrefix
        {
            get { return _serialPrefix; }
            set
            {
                _serialPrefix = value;
                _serial = this.serial;
                if (_initalised)
                    OnPropertyChanged("serialPrefix");
            }
        }


        public string serial
        {
            set
            {
                _serial = value;
                if (_initalised)
                    OnPropertyChanged("serial");
            }

            get
            {
                if (autoSerial && _initalised)
                    return Render.StringToString(this._serialFormat, this.ToDictionary(true, "serial"));
                return _serial;
            }

        }




        public string zwave
        {
            get { return _zwave; }
            set
            {
                _zwave = value;
                if (_initalised)
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

        public Dictionary<string, object> ToDictionary(bool KeyIsUpper)
        {
            if (KeyIsUpper)
            {
                var result = this.GetType()
                    .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .ToDictionary(prop => prop.Name.ToUpper(), prop => prop.GetValue(this, null));
                return result;
            }
            else
            {
                var result = this.GetType()
                    .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .ToDictionary(prop => prop.Name, prop => prop.GetValue(this, null));
                return result;
            }

        }

        public Dictionary<string, object> ToDictionary(bool KeyIsUpper, string ignoreField)
        {
            if (KeyIsUpper)
            {
                var result = this.GetType()
                    .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .Where(prop => prop.Name != ignoreField)
                    .ToDictionary(prop => prop.Name.ToUpper(), prop => prop.GetValue(this, null));
                return result;
            }
            else
            {
                var result = this.GetType()
                    .GetProperties(BindingFlags.Instance | BindingFlags.Public)
                    .Where(prop => prop.Name != ignoreField)
                    .ToDictionary(prop => prop.Name, prop => prop.GetValue(this, null));
                return result;
            }

        }
    }


}