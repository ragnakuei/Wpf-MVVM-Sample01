using System.ComponentModel;

namespace WpfApp13.ViewModels
{
    public class User : INotifyPropertyChanged  
    {  
        private string _firstName;  
        private string _lastName;  
      
        public string FirstName  
        {  
            get  
            {  
                return _firstName;  
            }  
            set  
            {  
                _firstName = value;  
                OnPropertyChanged("FirstName");  
            }  
        }  
        public string LastName  
        {  
            get  
            {  
                return _lastName;  
            }  
            set  
            {  
                _lastName = value;  
                OnPropertyChanged("LastName");  
            }  
        }  
 
        #region INotifyPropertyChanged Members  
  
        public event PropertyChangedEventHandler PropertyChanged;  
        private void OnPropertyChanged(string propertyName)  
        {  
            if (PropertyChanged != null)  
            {  
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));  
            }  
        }  
        #endregion  
  
    }
}