using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Models
{
    interface IClickModel
    {
        int NumClicked { get; }
        void OnClick();

    }
}
