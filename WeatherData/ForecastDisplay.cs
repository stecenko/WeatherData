using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherData
{
    // Элемент выводит прогноз погоды по показаниям барометра
    class ForecastDisplay :IObserver, IDisplayElement
    {
        void IObserver.Update(float temp, float hamidity, float pressure)
        {
            throw new NotImplementedException();
        }

        public void Display()
        {
            throw new NotImplementedException();
        }
    }
}
