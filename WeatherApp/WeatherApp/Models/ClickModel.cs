using System;
using System.Collections.Generic;
using System.Text;

namespace WeatherApp.Models
{
    class ClickModel : IClickModel
    {
        public int NumClicked { get; private set; }

        public void OnClick()
        {
            NumClicked++ ;
        }
    }
}
