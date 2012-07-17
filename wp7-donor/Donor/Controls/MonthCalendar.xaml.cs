﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Globalization;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using System.Windows.Media.Imaging;
using System.Collections.ObjectModel;
using Donor.ViewModels;

namespace Donor.Controls
{
    public partial class MonthCalendar : UserControl
    {
        public MonthCalendar()
        {
            InitializeComponent();

            UpdateCalendar();
        }

        public void UpdateCalendar() {
            this.CalendarDays.Children.Clear();
            Date = DateTime.Now;
            DateTime FirstDayPrev = new DateTime(DateTime.Now.AddMonths(-1).Year, DateTime.Now.AddMonths(-1).Month, 1);
            DateTime FirstDay = new DateTime(Date.Year, Date.Month, 1);
            int daysbefore = (int)FirstDay.DayOfWeek;

            /// Показываем минимальный период невозможности сдачи крови тем или иным образом
            int days = App.ViewModel.Events.DaysBefore();
            DateTime FromDays = new DateTime(1900,1,1);
            DateTime EndDays = new DateTime(1900,1,1);

            var nearestEvents = (from item in App.ViewModel.Events.Items
                                 where (item.Type =="1")
                                 orderby item.Date descending
                                 select item).Take(1);
            //(item.Date <= DateTime.Now) && 
            if (nearestEvents.FirstOrDefault() != null)
            {
                FromDays = nearestEvents.FirstOrDefault().Date;
                EndDays = FromDays.AddDays(days);
            };


            for (var i = (DateTime.DaysInMonth(FirstDayPrev.Year, FirstDayPrev.Month) - daysbefore); i < (DateTime.DaysInMonth(FirstDayPrev.Year, FirstDayPrev.Month) - 1); i++)
            {
                DayInCalendarControl day = new DayInCalendarControl();
                day.ImagePath = "/images/x.png";

                day.DayNumber = i.ToString();
                day.MonthNumber = FirstDayPrev.Month;
                day.YearNumber = FirstDayPrev.Year;
                day.Inactive = false;

                DateTime curDate = new DateTime(FirstDayPrev.Year, FirstDayPrev.Month, i);
                if (days != 0)
                {
                    if ((curDate <= EndDays) && (FromDays <= curDate))
                    {
                        day.BgColor = new SolidColorBrush(Colors.Gray);
                        day.Inactive = true;
                    };
                };

                day.TextColor = new SolidColorBrush(Colors.Gray);
                this.CalendarDays.Children.Add(day);
            };

            for (var i = 1; i <= DateTime.DaysInMonth(Date.Year, Date.Month); i++)
            {
                DayInCalendarControl day2 = new DayInCalendarControl();
                day2.ImagePath = null;
                day2.Tap += ClickDay;
                day2.EventDay = App.ViewModel.Events.Items.FirstOrDefault(a => a.Date == new DateTime(Date.Year, Date.Month, i));
                if ((day2.EventDay != null) && (day2.EventDay.Type == "Праздник"))
                {
                    day2.BgColor = new SolidColorBrush(Colors.DarkGray);
                };
                day2.MonthNumber = Date.Month;
                day2.YearNumber = Date.Year;
                day2.DayNumber = i.ToString();
                day2.TextColor = new SolidColorBrush(Colors.White);
                day2.Inactive = false;

                DateTime curDate = new DateTime(Date.Year, Date.Month, i);
                if (days != 0)
                {
                    if ((curDate <= EndDays) && (FromDays <= curDate))
                    {
                        day2.BgColor = new SolidColorBrush(Colors.Gray);
                        day2.Inactive = true;
                    };
                };

                this.CalendarDays.Children.Add(day2);
            };
        }

        public DateTime Date { get; set; }
        public ObservableCollection<EventViewModel> Items { get; set; }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            UpdateCalendar();
        }

        private void ClickDay(object sender, Microsoft.Phone.Controls.GestureEventArgs e)
        {
            //(Application.Current.RootVisual as PhoneApplicationFrame).Navigate(new Uri("/EventEditPage.xaml", UriKind.Relative));
        }
    }
}
