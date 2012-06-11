﻿using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Collections.Generic;
using System.Globalization;

namespace Donor.ViewModels
{
    public class EventViewModel
    {
        public EventViewModel()
        {
            this.Date = DateTime.Now;
        }

        public string Id { get; set; }
        public string Title { get; set; }
        public string Description {get; set; }
        private DateTime _date;
        public DateTime Date { 
            get
            {
                return _date;
            }
            set
            {
                _date = value;
            }
        }
        public string ShortDate
        {
            get
            {
                return _date.ToShortDateString();
            }
            private set { }
        }

        public string Image { get; set; }
        public string Type { get; set; }
        public string GiveType { get; set; }
        public string Place { get; set; }

        public string Reminder { get; set; }
        public bool ReminderMessage { get; set; }

        private DateTime _time;
        public DateTime Time {
            get
            {
                return _time;
            }
            set
            {
                _time = value;
            }
        }
        public string ShortTime
        {
            get
            {
                return _time.ToShortTimeString();
            }
            private set { }
        }
    }

    public class EventsListViewModel: INotifyPropertyChanged
    {
        public EventsListViewModel()
        {
            Items = new ObservableCollection<EventViewModel>();
        }
        private ObservableCollection<EventViewModel> _items;
        public ObservableCollection<EventViewModel> Items
        {
            get { return _items; }
            set
            {
                if (_items != value)
                {
                    _items = value;
                    this.NotifyPropertyChanged("Items");
                    this.NotifyPropertyChanged("WeekItems");
                };
            }
        }

        public List<EventViewModel> WeekItems { 
            get 
            {
                var newitems = (from eventCal in this.Items
                                where (eventCal.Date.Month == DateTime.Now.Month) && (eventCal.Date.Year == DateTime.Now.Year)
                               orderby eventCal.Date descending
                                select eventCal).Take(10);
                List<EventViewModel> outnews = newitems.ToList();
                return outnews;
            }
            private set { } 
        }

        public List<EventViewModel> ThisMonthItems
        {
            get
            {
                var newitems = (from eventCal in this.Items
                                where (eventCal.Date.Month == CurrentMonth.Month) && (eventCal.Date.Year == CurrentMonth.Year)
                                orderby eventCal.Date descending
                                select eventCal);
                List<EventViewModel> outnews = newitems.ToList();
                return outnews;
            }
            private set { }
        }

        private DateTime _currentMonth = DateTime.Now;
        public DateTime CurrentMonth {
            get {
                return _currentMonth;
            }
            set 
            { 
                _currentMonth = value;
                NotifyPropertyChanged("CurrentMonthString");
                NotifyPropertyChanged("NextMonthString");
                NotifyPropertyChanged("PrevMonthString");
                NotifyPropertyChanged("NextMonthItems");
                NotifyPropertyChanged("ThisMonthItems");
                NotifyPropertyChanged("PrevMonthItems");
            }
        }

        public string CurrentDate
        {
            get {
                return DateTime.Now.ToString("D");
                //CultureInfo.CurrentCulture.DateTimeFormat.LongDatePattern.;
            }
            private set
            {
            }
        }

        public string CurrentMonthString {
            get {
                return CultureInfo.CurrentCulture.DateTimeFormat.MonthNames[
CurrentMonth.Month-1]; 
            }
            private set { }
        }
        public string NextMonthString {
            get { return CultureInfo.CurrentCulture.DateTimeFormat.MonthNames[CurrentMonth.AddMonths(1).Month - 1]; }
            private set { }
        }
        public string PrevMonthString
        {
            get { return CultureInfo.CurrentCulture.DateTimeFormat.MonthNames[CurrentMonth.AddMonths(-1).Month - 1]; }
            private set { }
        }

        public List<EventViewModel> NextMonthItems
        {
            get
            {
                var newitems = (from eventCal in this.Items
                                where (eventCal.Date.Month == CurrentMonth.AddMonths(1).Month) && (eventCal.Date.Year == CurrentMonth.AddMonths(1).Year)
                                orderby eventCal.Date descending
                                select eventCal);
                List<EventViewModel> outnews = newitems.ToList();
                return outnews;
            }
            private set { }
        }

        public List<EventViewModel> PrevMonthItems
        {
            get
            {
                var newitems = (from eventCal in this.Items
                                where (eventCal.Date.Month == CurrentMonth.AddMonths(-1).Month) && (eventCal.Date.Year == CurrentMonth.AddMonths(-1).Year)
                                orderby eventCal.Date descending
                                select eventCal);
                List<EventViewModel> outnews = newitems.ToList();
                return outnews;
            }
            private set { }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged(String propertyName)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (null != handler)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }
}
