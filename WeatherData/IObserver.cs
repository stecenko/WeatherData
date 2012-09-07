using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherData
{
    // Все погодные елементы реализует интерфейс IObserver
    interface IObserver
    {   // наблюдатель 
        //данные состояния, передаваемые наблюдателям при изменении состояния субъекта:
        void Update(float temp, float hamidity, float pressure); // вызывается при изменении состояния субъекта
    }
}
