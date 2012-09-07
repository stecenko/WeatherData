using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherData
{
    interface ISubject
    {// инттерфейс субъекта. Используется объектами для регистрации в качестве наблюдателя
        void RegisterObserver(); // регистрируемый наблюдатель
        void RemoveObserver();   // исключаемый наблюдатель
        void NotifyObservers(); // вызывается для оповещения наблюдателей об изменении состояния субъекта
    }
}
