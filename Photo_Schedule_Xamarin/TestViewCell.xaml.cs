
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Photo_Schedule_Xamarin
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TestViewCell : ContentPage
    {
        public TestViewCell()
        {
            InitializeComponent();

            var layout = new StackLayout();

            var button = new Button
            {
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var one_Box = new BoxView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var two_Box = new BoxView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

            var three_Box = new BoxView
            {
                VerticalOptions = LayoutOptions.FillAndExpand,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

          

        }

        public StackLayout Content { get; }
    }
}
+