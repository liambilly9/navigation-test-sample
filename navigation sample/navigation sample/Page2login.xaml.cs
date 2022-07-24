using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace navigation_sample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page2login : ContentPage
    {
        public Page2login()
        {
            InitializeComponent();
        }

        private async void loginbtn_Clicked(object sender, EventArgs e)
        {
            MainPage mainPage = new MainPage();
            Page1 page1 = new Page1();
            var thename = username.Text;
            page1.BindingContext=new bindingclass(thename);
            MessagingCenter.Send<Page,string>(this,"LOGIN",thename);
            //await Navigation.PushModalAsync(page1);
            await Shell.Current.GoToAsync("..");
            //await Shell.Current.Navigation.PopAsync();
        }
    }
}