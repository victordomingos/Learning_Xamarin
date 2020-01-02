using System;
using System.Collections.Generic;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace buttons
{
    public partial class MyContentPage : ContentPage
    {
        private Random rnd = new Random();

        public MyContentPage()
        {
            InitializeComponent();

        }


        protected void ButtonClicked(object sender, EventArgs e)
        {
            ((Button)sender).Text = "Ok, not bad!";
        }


        async protected void PearTapped(object sender, EventArgs e)
        {
            Image img = (Image)sender;

            await img.FadeTo(0.5, 450);
            this.BackgroundColor = Color.FromRgb(rnd.Next(256),
                    rnd.Next(256),
                    rnd.Next(256));
            await Task.Delay(300);
            await img.FadeTo(1, 450);
        }
    }
}
