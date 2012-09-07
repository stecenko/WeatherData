using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WeatherData
{
    class WeatherData : ISubject
    {   

        static void Main(string[] args)
        {
        }

        public void MeasurementsShanged() // метод вызывается при каждом обновлении датчиков
        {

        }
        // эти 3 метода возвращают новые данные:
        public float GetTemperature()  //температура
        {
            float T=0;
            return T;
        }
        public float GetHamidity()    // влажность
        {   
            float H = 0;
            return H;
        }
        public float GetPresure()     // атмосферное давление
        {
            float P = 0;
            return P;
        }

        // Реализация интерфейса
        public void RegisterObserver()
        {
            throw new NotImplementedException();
        }

        public void RemoveObserver()
        {
            throw new NotImplementedException();
        }

        public void NotifyObservers()
        {
            throw new NotImplementedException();
        }
    }
}
