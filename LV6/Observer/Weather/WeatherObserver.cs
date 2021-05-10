using System;
using System.Collections.Generic;
using System.Text;

namespace Observer.Weather
{
    public interface WeatherObserver
    {
        void Update(int temperature);
    }
}
