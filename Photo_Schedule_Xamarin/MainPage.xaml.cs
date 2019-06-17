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

            Grid MainPage = new Grid();
            MainPage.VerticalOptions = LayoutOptions.FillAndExpand;
            MainPage.HorizontalOptions = LayoutOptions.FillAndExpand;

            MainPage.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            MainPage.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            MainPage.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });

            Label view_label = new Label();
            view_label.Text = "Test";
            view_label.FontSize = 30;
            view_label.TextColor = Color.FromHex("504946");
            view_label.BackgroundColor = Color.FromHex("bee0ce");
            MainPage.Children.Add(view_label, 0, 0);

            Calendar_Page_View calnedar_view = new Calendar_Page_View(2019,5,1);
            MainPage.Children.Add(calnedar_view, 0, 1);
            calnedar_view.BackgroundColor = Color.FromHex("fff3b8");
            Content = MainPage;
        }
        

    }
}
