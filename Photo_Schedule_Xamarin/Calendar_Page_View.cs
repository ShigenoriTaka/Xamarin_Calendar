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

            StackLayout Calendar_Layout = new StackLayout();

             Content =  Calendar_Layout;

            int tenp_day = - start_day + 0;

            for (int i=0; i< calendar_row; i++)
            {
                StackLayout row_Layout = new StackLayout();
                row_Layout.Orientation = StackOrientation.Horizontal;

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
                    textView.FontSize = 20;

                    if (j == 0)
                    {
                        textView.TextColor = Color.FromHex("");
                    }

                    if (j == 6)
                    {
                        textView.TextColor = Color.FromHex("");
                    }
                    if ((j >= 1) && (j <= 5))
                    {
                        textView.TextColor = Color.FromHex("");
                    }
                    if (tenp_day <= 0)
                    {
                        textView.TextColor = Color.FromHex("");
                    }
                    if (tenp_day > month_day)
                    {
                        textView.TextColor = Color.FromHex("");
                    }

                    row_Layout.Children.Add(textView);

                }
                Calendar_Layout.Children.Add(row_Layout);
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

