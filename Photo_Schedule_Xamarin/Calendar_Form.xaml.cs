using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Photo_Schedule_Xamarin
{
    public class StackLayout : ContentPage
    {
        public StackLayout()
        {
            var layout = new StackLayout();
            var button = new Button
            {
                Text = "StackLayout",
                VerticalOptions = LayoutOptions.Start,
                HorizontalOptions = LayoutOptions.FillAndExpand
            };
            var yellowBox = new BoxView 
            { 
                Color = Color.Yellow, 
                VerticalOptions = LayoutOptions.FillAndExpand, 
                HorizontalOptions = LayoutOptions.FillAndExpand
            };

        }

        public object Children { get; internal set; }
        public StackOrientation Orientation { get; internal set; }
        public int Spacing { get; internal set; }

        public static implicit operator View(StackLayout v)
        {
            throw new NotImplementedException();
        }
    }
