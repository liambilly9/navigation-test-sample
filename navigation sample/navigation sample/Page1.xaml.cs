using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace navigation_sample
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void show_Clicked(object sender, EventArgs e)
        {
            //try
            //{
            //    using (var client = new HttpClient())
            //    {
            //        var ulr = new Uri("https://www.azlyrics.com/lyrics/chrisbrown/next2you.html");
            //        StringBuilder lyricsonly = new StringBuilder();
            //        var url = client.GetAsync(ulr).Result;
            //        //var s=ulr.AbsoluteUri.Replace(ulr.Query,"");
            //        var json = url.Content.ReadAsStringAsync().Result;
            //        #region stringbuilding
            //        var str = Regex.Replace(json, @"<script[^>]*>[\s\S]*?</script>", string.Empty);
            //        var newstr = Regex.Replace(str, "<.*?>", string.Empty);
            //        ////var trimmed = newstr.Trim();
            //        //int edited = newstr.IndexOf("Search");
            //        //int from = newstr.IndexOf("Submit Corrections");
            //        //int to = newstr.Length-1;
            //        //var subbed = newstr.Substring(edited, from);
            //        //lyricsonly.AppendLine(subbed);


            //        //lyricsonly.Replace(",", Environment.NewLine);
            //        ////lyricsonly.Remove(from, to);
            //        ////lyricsonly.Remove(0, 6);
            //        //lyricsonly.Replace("AZLyrics", "");
            //        //string v = Regex.Replace(lyricsonly.ToString(), @"\s+", "").Trim();
            //        //string u = lyricsonly.ToString();
            //        //string w = u.Trim();
            //        //StringBuilder x = new StringBuilder();
            //        //foreach (char c in lyricsonly.ToString())
            //        //{
            //        //    if (!char.IsWhiteSpace(c))
            //        //    {
            //        //        x.Append(c);
            //        //    }
            //        //}
            //        //string y = x.ToString();
            //        #endregion
            //        //var tostring = JsonConvert.SerializeObject(json);
                    
            //        lyrics.Text=newstr;
            //    }

            //}
            //catch (Exception ex)
            //{
            //    lyrics.Text=ex.Message;

            //}
            Shell.Current.GoToAsync(nameof(Page2login));
        }
    }
}