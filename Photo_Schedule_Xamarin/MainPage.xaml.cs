using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Photo_Schedule_Xamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {

        public MainPage()
        {
            InitializeComponent();
            EmptyClass Test4 = new EmptyClass();
            Test4.test3();

            var Text_01 = new Label();
            var calendar = new StackLayout
            {
                Children =
                {
                    new BoxView // CalendarImege
                     {
                        HeightRequest = 300,
                        BackgroundColor = Color.FromHex("eddc44")
                    },

                    
                }
            };

            calendar.Children.Add(new Calendar_Page_View(2019, 5, 30));

            Content = calendar;



         
        }
       
    }
}
