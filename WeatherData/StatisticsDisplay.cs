using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherData
{
    class StatisticsDisplay : IObserver, IDisplayElement
    {
        public void Update(float temp, float hamidity, float pressure)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }
    }
}
