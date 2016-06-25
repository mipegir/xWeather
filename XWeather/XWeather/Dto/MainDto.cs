﻿using MvvmCross.Core.ViewModels;

namespace XWeather.Dto
{
    public class MainDto : MvxViewModel
    {
        private double _temp;
        private int _pressure;
        private int _humidity;
        private double _tempMin;
        private double _tempMax;

        public double Temp
        {
            get { return _temp; }
            set { _temp = value; RaisePropertyChanged(); }
        }

        public int Pressure
        {
            get { return _pressure; }
            set { _pressure = value; RaisePropertyChanged(); }
        }

        public int Humidity
        {
            get { return _humidity; }
            set { _humidity = value; RaisePropertyChanged(); }
        }

        public double TempMin
        {
            get { return _tempMin; }
            set { _tempMin = value; RaisePropertyChanged(); }
        }

        public double TempMax
        {
            get { return _tempMax; }
            set { _tempMax = value; RaisePropertyChanged(); }
        }
    }
}