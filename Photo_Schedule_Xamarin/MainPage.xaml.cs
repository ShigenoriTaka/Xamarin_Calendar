using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using CarouselView.FormsPlugin;
using System.Collections.ObjectModel;
using Photo_Schedule_Xamarin.Models;
using CarouselView.FormsPlugin.Abstractions;

namespace Photo_Schedule_Xamarin
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(true)]
    public partial class MainPage : ContentPage
    {
        public ObservableCollection<Page_info> Carousel_Page_info { get; set; }


        public MainPage()
        {
            InitializeComponent();
            BackgroundImage = "note_line";
            var relativeLayout = new RelativeLayout();

            //グリッド　ページ全体のUIデザインの基本ルールの設定
            Grid MainPage = new Grid();
            MainPage.VerticalOptions = LayoutOptions.End;
            MainPage.HorizontalOptions = LayoutOptions.FillAndExpand;
            MainPage.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            MainPage.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            MainPage.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            MainPage.Padding = new Thickness(10, 10, 10, 60);
            MainPage.RowSpacing = 0;

            //各ラベルの実装
            Label view_label = new Label();
            view_label.Text = "Test";
            view_label.FontSize = 30;
            view_label.TextColor = Color.FromHex("504946");
            view_label.BackgroundColor = Color.FromHex("bee0ce");

            var image = new Image { Source = "test_photo" };

            relativeLayout.Children.Add(image,
                Constraint.Constant(0),
                Constraint.RelativeToParent(Parent => 0),
                Constraint.RelativeToParent(Parent => Parent.Width),
                Constraint.RelativeToParent(Parent => Parent.Height)
                ) ;
            
            relativeLayout.Children.Add(view_label,
                Constraint.Constant(30),
                Constraint.RelativeToParent(Parent => Parent.Height /2));
            //MainPage.Children.Add(relativeLayout, 0, 0);

            //Carousel_Page_infoを２４カ月分性作る。
            CarouselViewControl carouselViewControl = new CarouselViewControl();
            carouselViewControl.ItemsSource = Carousel_Page_info;

       
            Title = "Main Page";

            this.Carousel_Page_info = new ObservableCollection<Page_info>
            {
                new Page_info
                {
                    year = 2019,
                    month= 7,
                    day= 5
                },
                new Page_info
                {
                    year = 2019,
                    month= 8,
                    day= 5
                },
                new Page_info
                {
                    year = 2019,
                    month= 9,
                    day= 5
                }
            };






        Calendar_Page_View calnedar_view = new Calendar_Page_View(2019,5,1);
            MainPage.Children.Add(calnedar_view, 0, 1);
            calnedar_view.BackgroundColor = Color.FromHex("fff3b8");



          //Content = MainPage;
        }
        

    }
}
