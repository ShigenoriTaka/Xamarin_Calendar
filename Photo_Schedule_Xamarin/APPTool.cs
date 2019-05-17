using System;
using Xamarin.Forms;
using System.Globalization;

namespace Photo_Schedule_Xamarin
{
    public class APPTool
    {
        private Label Text_tool_01;
        private Label Text_tool_02;
        private Label Text_tool_03;

        public void init(Label _text_tool_01, Label _text_tool_02, Label _text_tool_03)
        {
            Text_tool_01 = _text_tool_01;
            
            Text_tool_02 = _text_tool_02;

            Text_tool_03 = _text_tool_03;
        }

        public void Texttool(DateTime datetime)
        {
            

            Calendar calendar = CultureInfo.InvariantCulture.Calendar;
            int this_month = calendar.GetMonth(DateTime.Today);

            int year = calendar.GetYear(datetime);

                Text_tool_01.Text = year.ToString();

            int month = calendar.GetMonth(datetime);
            String monthName = theMonth(month);
            Text_tool_02.Text = monthName;

            int day = calendar.GetDayOfMonth(datetime);
            Text_tool_03.Text = day.ToString() ;
            if (month != this_month)
            {
                Text_tool_03.Text = " ";
            }

        }

        public static String theMonth(int month)
        {
            String[] monthNames = {"January", "February", "March", "April", "May", "June", "July",
                "August", "September", "October", "November", "December"};
            return monthNames[month];
        }

    }
}
