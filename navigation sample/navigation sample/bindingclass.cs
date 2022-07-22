using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace navigation_sample
{
    public class bindingclass : INotifyPropertyChanged
    {
        
        private string password;
        private string email;
        string username;
        public bindingclass(string username)
        {
            this.username = username;
        }
        public bindingclass()
        {
            UserName="tap profile to log in";
        }
        public String Email
        {
            get => email;
            set
            {
                email = value;
                OnPropertyChanged("Email");
            }
        }
        public String UserName
        {
            get => username;
            set
            {
                username = value;
                OnPropertyChanged(nameof(UserName));
            }
        }
        public String Password
        {
            get => password;
            set
            {
                password = value;
                OnPropertyChanged("Password");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(string theproperty)
        {
            if (PropertyChanged != null)
                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(theproperty));
        }
    }
}
