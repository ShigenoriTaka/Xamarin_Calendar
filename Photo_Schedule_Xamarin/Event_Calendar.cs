using System;

using Xamarin.Forms;

namespace Photo_Schedule_Xamarin
{
    public class TestPage : ContentPage
    {
        public TestPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

