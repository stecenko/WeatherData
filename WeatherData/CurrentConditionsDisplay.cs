using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherData 
{
    // выводит текущие значения переменных объекта WeatherData
    class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        public void Update(float temp, float hamidity, float pressure)
        {
            throw new NotImplementedException();
        }

        public void Display() // вывод статистики
        {
            throw new NotImplementedException();
        }
    }
}
