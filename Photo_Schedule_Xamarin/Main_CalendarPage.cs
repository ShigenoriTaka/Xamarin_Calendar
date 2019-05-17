using System;

using Xamarin.Forms;

namespace Photo_Schedule_Xamarin
{
    public class Main_CalendarPage : ContentPage
    {
        public Main_CalendarPage()
        {
            Label label = new Label { Text = "Hello ContentPage" };
            Content = new StackLayout
            {
                Children = {
                    label
                }
            };
        }
    }
}

