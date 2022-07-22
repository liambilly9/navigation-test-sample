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
        }

        private async void myprof_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushModalAsync(new Page2login(), true);
        }
    }
}
