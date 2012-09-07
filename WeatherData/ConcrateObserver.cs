using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherData
{
        // НАБЛЮДАТЕЛЬ
    class ConcrateObserver : IObserver
    {
        void IObserver.Update(float temp, float hamidity, float pressure)
        {    // вызывается при изменении состояния субъекта
            throw new NotImplementedException();
        }
    }
}
