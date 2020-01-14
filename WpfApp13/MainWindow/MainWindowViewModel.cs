using System;
using System.Collections.Generic;
using System.Windows.Input;
using WpfApp13.ViewModels;
using System.ComponentModel;

namespace WpfApp13
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        public MainWindowViewModel()
        {
            Users = new List<User>
                    {
                        new User
                        {
                            FirstName = "Raj",
                            LastName = "Beniwal"
                        },
                        new User
                        {
                            FirstName = "Mark",
                            LastName = "henry"
                        },
                        new User
                        {
                            FirstName = "Mahesh",
                            LastName = "Chand"
                        },
                        new User
                        {
                            FirstName = "Vikash",
                            LastName = "Nanda"
                        },
                        new User
                        {
                            FirstName = "Harsh",
                            LastName = "Kumar"
                        },
                        new User
                        {
                            FirstName = "Reetesh",
                            LastName = "Tomar"
                        },
                        new User
                        {
                            FirstName = "Deven",
                            LastName = "Verma"
                        },
                        new User
                        {
                            FirstName = "Ravi",
                            LastName = "Taneja"
                        }
                    }
                ;

            WindowOnLoadCommand = new MainWindowViewModelOnLoadCommand(OnLoadExecute);
            ConfirmOnClickCommand = new ConfirmClickCommand(ConfirmOnClickExecute);
        }

        private void ConfirmOnClickExecute()
        {
        }

        private void OnLoadExecute()
        {
            SelectedUser = null;
            SelectedUserIndex = -1;
        }


        public List<User> Users { get; }

        #region Command

        public ICommand WindowOnLoadCommand { get; set; }
        public ICommand ConfirmOnClickCommand { get; set; }

        private class MainWindowViewModelOnLoadCommand : BaseCommand
        {
            public MainWindowViewModelOnLoadCommand(Action execute)
                : base(execute)
            {
            }

            public MainWindowViewModelOnLoadCommand(Action execute, Func<bool> canExecute)
                : base(execute, canExecute)
            {
            }
        }

        private class ConfirmClickCommand : BaseCommand
        {
            public ConfirmClickCommand(Action execute)
                : base(execute)
            {
            }

            public ConfirmClickCommand(Action execute, Func<bool> canExecute)
                : base(execute, canExecute)
            {
            }
        }

        #endregion

        #region INotifyPropertyChanged Members

        private int _selectedUserIndex;
        private User _selectedUser;

        public User SelectedUser
        {
            get => _selectedUser;
            set
            {
                _selectedUser = value;
                OnPropertyChanged("SelectedUser");  
            }
        }

        public int SelectedUserIndex
        {
            get => _selectedUserIndex;
            set
            {
                _selectedUserIndex = value;
                OnPropertyChanged("SelectedUserIndex");  
            }
        }

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