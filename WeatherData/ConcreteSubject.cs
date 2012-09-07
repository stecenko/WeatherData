using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherData
{
    class ConcreteSubject : ISubject
    {
        public void RegisterObserver()
        {
            throw new NotImplementedException();
        }

        public void RemoveObserver()
        {
            throw new NotImplementedException();
        }

        public void NotifyObservers() // вызывается для оповещения наблюдателей об изменении состояния субъекта
        {
            throw new NotImplementedException();
        }


        // методы для изменения состояния. Может иметь методы get и set
        public void GetState()
        {

        }

        public void SetState()
        {

        }

    }
}
