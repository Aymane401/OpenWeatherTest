﻿using System.Windows;

namespace WeatherApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// Author : Nicolas Bourré
    /// Date : 2021-10-25
    /// </summary>
    public partial class App : Application
    {

        public App()
        {

          string cle = AppConfiguration.GetValue("apikey");
        }
    }
}
