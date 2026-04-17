using System;
using System.Collections.Generic;
namespace IndustrialMonitor
{
    public class MachineMonitor : IObservable
    {
        private readonly List<IObserver> _observers = new List<IObserver>();
        // Пороговые значения (вынесены в константы)
        private const double CriticalTemperature = 100.0;
        private const double CriticalVibration = 5.5;
        private const double CriticalLoad = 85.0;
        private const double CriticalSpeed = 3000.0;
        // Реализация интерфейса IObservable 
        public void Attach(IObserver observer)
        {
            if (!_observers.Contains(observer))
            {
                _observers.Add(observer);
                Console.WriteLine($"[Система] Подключен наблюдатель: {observer.GetType().Name}");
            }
        }
        public void Detach(IObserver observer)
        {
            if (_observers.Remove(observer))
            {
                Console.WriteLine($"[Система] Отключен наблюдатель: {observer.GetType().Name}");
            }
        }
        public void Notify(string message)
        {
            foreach (var observer in _observers)
            {
                observer.Update(message);
            }
        }
        // Методы проверки параметров
        public void CheckTemperature(double value)
        {
            Console.WriteLine($"[Датчик] Температура: {value}°C");
            if (value > CriticalTemperature)
            {
                Notify($"КРИТИЧЕСКОЕ ЗНАЧЕНИЕ! Температура: {value}°C (норма: до {CriticalTemperature}°C)");
            }
        }
        public void CheckVibration(double value)
        {
            Console.WriteLine($"[Датчик] Вибрация: {value} мм/с");
            if (value > CriticalVibration)
            {
                Notify($"КРИТИЧЕСКОЕ ЗНАЧЕНИЕ! Вибрация: {value} мм/с (норма: до {CriticalVibration} мм/с)");
            }
        }
        public void CheckLoad(double value)
        {
            Console.WriteLine($"[Датчик] Нагрузка: {value}%");
            if (value > CriticalLoad)
            {
                Notify($"КРИТИЧЕСКОЕ ЗНАЧЕНИЕ! Нагрузка: {value}% (норма: до {CriticalLoad}%)");
            }
        }
        public void CheckSpeed(double value)
        {
            Console.WriteLine($"[Датчик] Скорость вращения: {value} об/мин");
            if (value > CriticalSpeed)
            {
                Notify($"КРИТИЧЕСКОЕ ЗНАЧЕНИЕ! Скорость вращения: {value} об/мин (норма: до {CriticalSpeed} об/мин)");
            }
        }
    }
}