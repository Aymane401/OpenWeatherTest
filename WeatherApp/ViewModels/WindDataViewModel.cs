﻿using WeatherApp.Commands;
using WeatherApp.Models;
using WeatherApp.Services;

namespace WeatherApp.ViewModels
{
    public class WindDataViewModel : BaseViewModel
    {
        public IWindDataService WindDataService { get; set; }
        public DelegateCommand<string> GetDataCommand { get; set; }
        private WindDataModel curD;
      
        public double KPHtoMPS(double kph) => kph * 1.0 / 36.0;
        public double MPStoKPH(double mps) => mps * 3.6;




        public WindDataModel CurrentData
        {
            get => curD;
            set
            {
                curD = value;
                OnPropertyChanged();
            }
        }


    }
}
