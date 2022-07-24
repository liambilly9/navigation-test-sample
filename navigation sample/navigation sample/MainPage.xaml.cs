using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace navigation_sample
{
    public partial class MainPage : Shell
    {
        public MainPage()
        {
            InitializeComponent();
            //Routing.RegisterRoute(nameof(Page1),typeof(Page1));
            Routing.RegisterRoute(nameof(Page2login), typeof(Page2login));
        }

        private async void myprof_Clicked(object sender, EventArgs e)
        {
            MessagingCenter.Subscribe<Page,string>(this,"LOGIN",(p,usernamee) =>
            {
                username.Text=usernamee;
            });
            await Navigation.PushModalAsync(new Page2login(), true);
            //await Shell.Current.GoToAsync(nameof(Page2login));
        }
    }
}
