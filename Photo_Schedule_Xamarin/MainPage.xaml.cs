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
        public float x { get; set; }
        public float y { get; set; }

        public MainPage()
        {
            InitializeComponent();
            EmptyClass Test4 = new EmptyClass();
            Test4.test3();

            StackLayout layout = new StackLayout
            {
                Spacing = 0
            };
            layout.Orientation = StackOrientation.Vertical;
            layout.Padding = new Thickness(10, 10);
            

            RelativeLayout Imeagelayout = new RelativeLayout
            {
                VerticalOptions = LayoutOptions.Start,
                HeightRequest = 300,
                BackgroundColor = Color.Yellow
            };

            var Text_01 = new Label();
            var centerX = Constraint.RelativeToParent(Parent => Parent.Width / 2);
            var centerY = Constraint.RelativeToParent(Parent => Parent.Height / 2);

            var Text_02 = new Label();

            var Text_03 = new Label();


            Imeagelayout.Children.Add(Text_01, centerX, centerY);
            Imeagelayout.Children.Add(Text_02, centerX, centerY);
            Imeagelayout.Children.Add(Text_03, centerX, centerY);

            APPTool texttool_Box = new APPTool();


            texttool_Box.init(Text_01,Text_02,Text_03);
            texttool_Box.Texttool(DateTime.Today);

            RelativeLayout Imeagelayout2 = new RelativeLayout
            {
                VerticalOptions = LayoutOptions.Start,
                HeightRequest = 300,
                BackgroundColor = Color.Green
            };

            layout.Children.Add(Imeagelayout);
            layout.Children.Add(Imeagelayout2);
            Content = layout;
        }
    }
}
