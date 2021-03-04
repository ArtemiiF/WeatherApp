using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using WeatherApp.Models;
using Xamarin.Forms;

namespace WeatherApp.ViewModels
{
    class MainPageViewModel : BaseViewModel
    {
        private IClickModel clickModel;
        public ICommand button_clicked { get; private set; }

        private JSONWeather weather;

        private string city = "";
        private string temp = "";
        public string labelOfCityNTemp()
        {
            if (clickModel.NumClicked == 0)

                return "";

            else
                return "In " + city + " is " + temp + "°C";
        }

        public string Clicked
        {
            get
            {
                return clickModel.NumClicked.ToString();
            }
        }

        public string WeatherInCity
        {
            get
            {
                return labelOfCityNTemp();
            }
        }

        public MainPageViewModel()
        {
            button_clicked = new Command(OnButtonClick);
            clickModel = new ClickModel();
            weather = new JSONWeather();
        }

        private void OnButtonClick()
        {
            clickModel.OnClick();
            city = "London";
            temp = weather.JSONCityCurrTemp(city);
            NotifyPropertyChanged(nameof(Clicked));
            NotifyPropertyChanged(nameof(WeatherInCity));
        }

    }
}
