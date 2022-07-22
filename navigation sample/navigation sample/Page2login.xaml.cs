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
            var thename = username.Text;
            mainPage.BindingContext=new bindingclass(thename);
            
            await Navigation.PopModalAsync();
        }
    }
}