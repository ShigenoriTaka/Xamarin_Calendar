using System;
using System.Globalization;

using Xamarin.Forms;

namespace Photo_Schedule_Xamarin
{
    public class Calendar_Page_View : ContentView
    {
        public Calendar_Page_View(int year, int month, int day)
        {
            int month_day = get_manth_day(year,month);
        
            int last_month_endday = get_lastmonth_endday(year,month);
            int start_day = get_C_dayStrat(year,month);
            int calendar_row = get_C_Row(start_day,month_day);

            Grid Calendar_Layout = new Grid();
            Calendar_Layout.VerticalOptions = LayoutOptions.FillAndExpand;
            Calendar_Layout.HorizontalOptions = LayoutOptions.FillAndExpand;

            for (int i = 0; i < 7; i++)
            {
                Calendar_Layout.ColumnDefinitions.Add(new ColumnDefinition { Width = new GridLength(1, GridUnitType.Star) });
            }

            for (int j = 0; j < calendar_row + 1; j++)
            {
                Calendar_Layout.RowDefinitions.Add(new RowDefinition { Height = new GridLength(1, GridUnitType.Star) });
            }

            string[] Week_day_name = {"Sun","Mon","Tue","Wed","Thu","Fri","Sat" };

            for (int x = 0; x <7; x++)
            {
                Label label = new Label();
                label.Text = Week_day_name[x];
                label.FontSize = 20;
                Calendar_Layout.Children.Add(label, x, 0);
                label.HorizontalOptions = LayoutOptions.Center;

                if (x == 0)
                {
                    label.TextColor = Color.FromHex("cc0033");
                }

                if (x == 6)
                {
                    label.TextColor = Color.FromHex("3366ff");
                }
            }

            Content =  Calendar_Layout;

            int tenp_day = - start_day + 0;

            for (int i=0; i< calendar_row; i++)
            {
           

                for (int j = 0; j < 7; j++)
                {
                    tenp_day++;
                    string daystring;
                    if (tenp_day <= 0)
                    {
                        daystring = "" + (last_month_endday + tenp_day);
                    }
                    else if (tenp_day > month_day)
                    {
                        daystring = "" + (tenp_day - month_day);
                    }
                    else if (tenp_day >= 1)
                    {
                        daystring = tenp_day + "";
                    }
                    else
                    {
                        daystring = "";
                    }
                    Label textView = new Label();
                    textView.Text = daystring;
                    textView.FontSize = 25;
                    textView.HorizontalOptions = LayoutOptions.Center;

                    if (j == 0)
                    {
                        textView.TextColor = Color.FromHex("cc0033");
                    }

                    if (j == 6)
                    {
                        textView.TextColor = Color.FromHex("3366ff");
                    }
                    if ((j >= 1) && (j <= 5))
                    {
                        textView.TextColor = Color.FromHex("626063");
                    }
                    if (tenp_day <= 0)
                    {
                        textView.TextColor = Color.FromHex("abb1ad");
                    }
                    if (tenp_day > month_day)
                    {
                        textView.TextColor = Color.FromHex("abb1ad");
                    }

                    Calendar_Layout.Children.Add(textView, j , i + 1);

                }
               
            }
          

        }

        private int get_manth_day(int year, int month)
        {
            return DateTime.DaysInMonth(year, month);
        }
        //先月の日数を返すメソッド
        private int get_lastmonth_endday(int year,int month)
        {
            DateTime Last_Month_day = new DateTime(year,month,1);
            Calendar Call_Calendar = CultureInfo.InvariantCulture.Calendar;
            Last_Month_day = Call_Calendar.AddMonths(Last_Month_day, -1);
            return DateTime.DaysInMonth(Last_Month_day.Year, Last_Month_day.Month);
        }
        //カレンダーの横列を計算するメソッド
        private int get_C_Row(int strat_day, int month_day)
        {
            float row = (float)(strat_day - 1 + month_day) / 7f;
            return (int)Math.Ceiling(row);
        }
        //カレンダーの月の最初の日日を取得する
        private int get_C_dayStrat(int year, int month)
        {
            DateTime first_day = new DateTime(year,month,1);
            return (int)first_day.DayOfWeek;
        }

    }
}

