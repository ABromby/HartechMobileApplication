using System.ComponentModel;
using System.Runtime.CompilerServices;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace Hartech.MVVM.ViewModel
{
    public class VMCode : INotifyPropertyChanged
    {

        private static string _customerCode { get; set; }
        //string myKey = Preferences.Get("my_key", _customerCode);

        public string CustomerCode { 

            get
            {

                //if (Preferences.Get("my_Key", _customerCode) == null)
                // {
                //     return _customerCode;
                // }
                // else
                // {
                Preferences.Get("my_Key", _customerCode);
                return _customerCode;
               // }
            }
            set
            {
                _customerCode = value;
                App.UserCode = Preferences.Get("my_Key", _customerCode);
                OnPropertyChange();
            }
        }

        private static string _message { get; set; }
        public string Message
        {
            get { return _message; }
            set
            {
                _message = value;
                OnPropertyChange();
            }
        }

        public Command Apply
        {
            get
            {
                Preferences.Set("my_Key", _customerCode);
                
                return new Command(() => { Message = $"Your unique code is {App.UserCode}"; });

            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChange([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
