using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace helloforms
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void btn_dont_touch_Clicked(object sender, EventArgs e)
        {
            lbl_ola.IsVisible = true;
            lbl_ola.Text = "Can't you read?";
            imgbanana.IsVisible = false;
        }

        private void btn_touch_Clicked(object sender, EventArgs e)
        {
            lbl_ola.IsVisible = false;
            imgbanana.IsVisible = true;

        }
    }
}
