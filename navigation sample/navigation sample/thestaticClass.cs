using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using Xamarin.Essentials;

namespace navigation_sample
{
    public static class thestaticClass
    {
        private static string password;
        private static string email;
        static string username;
        static thestaticClass()
        {

        }
        public static String Email
        {
            get => email;
            set
            {
                email = value;
                //OnPropertyChanged("Email");
            }
        }
        public static String UserName
        {
            get => username;
            set
            {
                username = value;
                //OnPropertyChanged(nameof(UserName));
            }
        }
        public static String Password
        {
            get => password;
            set
            {
                password = value;
                //OnPropertyChanged("Password");
            }
        }

        //public static event PropertyChangedEventHandler PropertyChanged;
        //public static void OnPropertyChanged(string theproperty)
        //{
        //    if (PropertyChanged != null)
        //        PropertyChanged.Invoke(this, new PropertyChangedEventArgs(theproperty));
        //}
    }
}
